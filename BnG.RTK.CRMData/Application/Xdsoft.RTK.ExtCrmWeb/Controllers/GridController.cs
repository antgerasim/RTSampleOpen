using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xdsoft.RTK.ExtCrmWeb.Data;
using Xdsoft.RTK.ExtCrmWeb.Models;
using Xdsoft.RTK.ExtCrmWeb.ViewModels;

namespace Xdsoft.RTK.ExtCrmWeb.Controllers
{
    public class GridController : Controller
    {
        RTCRM Db = new RTCRM();

        public string ContractPlanId { get; set; }
        public string QuarterHighlight { get; set; }

        public ActionResult Index(string parenttableid, string quarterhlight)
        {
            //http://localhost:50895/?parenttableid=3D317583-36B0-E811-80D3-DBE78F6B8753
            //http://localhost:47186/grid/?parenttableid=C53CEED0-83DE-E811-80D8-EA772D54D6FA&quarterhlight=q1

            var ptid = parenttableid == null ? "3D317583-36B0-E811-80D3-DBE78F6B8753" : parenttableid;
            var qhlight = quarterhlight == null ? "q1" : quarterhlight;    
            ContractPlanId = ptid;
            QuarterHighlight = qhlight;

            Session["parenttableid"] = ptid;
            Session["quarterhlight"] = qhlight;           
            return View(new ViewModels.IndexViewModel(ptid, qhlight));
        }

        [ValidateInput(false)]
        public ActionResult BatchEditingPartial(string parenttableid, string quarterhlight)
        {            
            if (Request.IsAjaxRequest())
            {
                var ptid = Session["parenttableid"] as string;
                var qhlight = Session["quarterhlight"] as string;                
                var ajaxmodel = GetEditableViewModelContracts(new Guid(ptid));
                return PartialView("_BatchEditingPartial", ajaxmodel);
            }

            new_contract_planBase parentTable = null;
            int contractStatus = default(int);

            parentTable = Db.new_contract_planBase.FirstOrDefault(x => x.new_contract_planId == new Guid(parenttableid));
            if (parentTable == null)
            {
                var excText = "Для работы с планом контрактования необходимо сначало его сохранить.";
                return View("~/Views/Home/IdNotFound.cshtml", new IdNotFoundViewModel(excText));
            }
            contractStatus = parentTable.statuscode ?? 2;


            Session["contractstatus"] = contractStatus.ToString();
            var model = GetEditableViewModelContracts(new Guid(parenttableid));
            var urlTest = Request.RawUrl;
            return PartialView("_BatchEditingPartial", model);
        }
        
        [HttpPost, ValidateInput(false)]
        public ActionResult BatchEditingUpdateModel(MVCxGridViewBatchUpdateValues<EditableProduct, Guid> updateValues)
        {
            var dataContextModelContracts = GetDataContextModelContracts();
            // Insert all added values. 
            foreach (var contract in updateValues.Insert)
            {
                if (updateValues.IsValid(contract))
                {
                    try
                    {
                        InsertContract(contract, dataContextModelContracts);
                        Db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        updateValues.SetErrorText(contract, e.Message);
                    }
                }
            }
            // Update all edited values. 
            //get sum of all total values         
            foreach (var contract in updateValues.Update)
            {
                if (updateValues.IsValid(contract))
                {
                    try
                    {
                        var product = UpdateContract(contract);
                        Db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        updateValues.SetErrorText(contract, e.Message);
                    }
                }
                else
                {
                    updateValues.SetErrorText(contract, "Исправьте ошибки заполнения формы");
                }
            }

            // Delete all values that were deleted on the client side from the data source. 
            foreach (var ContrGUID in updateValues.DeleteKeys)
            {
                try
                {
                    DeleteContract(ContrGUID, dataContextModelContracts);
                    Db.SaveChanges();
                }
                catch (Exception e)
                {
                    updateValues.SetErrorText(ContrGUID, e.Message);
                }
            }
            var parenttableid = Session["parenttableid"] as string;
            var quarterhlight = Session["quarterhlight"] as string;           
            return BatchEditingPartial(parenttableid, quarterhlight);
        }

        private void DeleteContract(Guid contrGuid, IList<new_contract_plan_productBase> dataContextModelContracts)
        {
            var dataContract = GetDataContextModelContract(contrGuid);
            if (dataContract != null)
            {
                GetDataContextModelContracts().Remove(dataContract);
            }
        }

        private void InsertContract(EditableProduct editContract, IList<new_contract_plan_productBase> dataContextModelContracts)
        {
            var dataContextModelContract = new new_contract_plan_productBase();
            //initialize childs for null reference errors
            dataContextModelContract.new_d_product_groupsBase = new new_d_product_groupsBase();
            dataContextModelContract.new_d_product_catalogBase = new new_d_product_catalogBase();

            dataContextModelContract.new_contract_plan_productId = Guid.NewGuid(); //todo check if EF or db add guid automatically
            dataContextModelContract.new_d_product_groupsBase.new_name = editContract.ProductGroupProduct;
            dataContextModelContract.new_d_product_catalogBase.new_name = editContract.Product;
            dataContextModelContract.new_service_1_quarter = editContract.Service1Quarter;
            dataContextModelContract.new_consulting_1_quarter = editContract.Consult1Quarter;            
            Db.new_contract_plan_productBase.ToList().Add(dataContextModelContract);
        }

        private new_contract_plan_productBase UpdateContract(EditableProduct editProduct)
        {
            var product = Db.new_contract_plan_productBase.FirstOrDefault(prod => prod.new_contract_plan_productId == editProduct.ProductId);
    
            if (product != null)
            {
                product.new_service_1_quarter = editProduct.Service1Quarter; //save 2 times same values and look if second update contains values from first 
                product.new_service_2_quarter = editProduct.Service2Quarter;
                product.new_service_3_quarter = editProduct.Service3Quarter;
                product.new_service_4_quarter = editProduct.Service4Quarter;
                product.new_consulting_1_quarter = editProduct.Consult1Quarter;
                product.new_consulting_2_quarter = editProduct.Consult2Quarter;
                product.new_consulting_3_quarter = editProduct.Consult3Quarter;
                product.new_consulting_4_quarter = editProduct.Consult4Quarter;
                product.new_service_year = editProduct.NewServiceYear; //переходящие сервис
                product.new_consulting_year = editProduct.NewConsultYear; //переходящие консалтинг                                                                       
                                                                        
                product.new_year_sum = editProduct.NewServiceYear + editProduct.NewConsultYear;//переходящие контракты сумма год
               
                product.new_product_sum_service = editProduct.Service1Quarter + editProduct.Service2Quarter + editProduct.Service3Quarter + editProduct.Service4Quarter;  // сервис год
                product.new_product_sum_consulting = editProduct.Consult1Quarter + editProduct.Consult2Quarter + editProduct.Consult3Quarter + editProduct.Consult4Quarter;//консалт год
            }

            return product;
        }

        private decimal calculateContractAnnualTotal(decimal consltTotal, decimal serviceTotal)
        {
            var retVal = default(decimal);

            return retVal;
        }

        private IList<EditableProduct> GetEditableViewModelContracts(Guid filterId)
        {
            IQueryable<EditableProduct> query = Db.new_contract_plan_productBase
              .Where(x => x.new_link_contract_plan_year_id == filterId)
              .Select(dataContextModelContract => new EditableProduct
              {
                  ProductId = dataContextModelContract.new_contract_plan_productId,
                  ProductGroupProduct = dataContextModelContract.new_d_product_groupsBase.new_name,
                  Product = dataContextModelContract.new_d_product_catalogBase.new_name,
                  Service1Quarter = dataContextModelContract.new_service_1_quarter ?? Decimal.Zero,
                  Service2Quarter = dataContextModelContract.new_service_2_quarter ?? Decimal.Zero,
                  Service3Quarter = dataContextModelContract.new_service_3_quarter ?? Decimal.Zero,
                  Service4Quarter = dataContextModelContract.new_service_4_quarter ?? Decimal.Zero,
                  Consult1Quarter = dataContextModelContract.new_consulting_1_quarter ?? Decimal.Zero,
                  Consult2Quarter = dataContextModelContract.new_consulting_2_quarter ?? Decimal.Zero,
                  Consult3Quarter = dataContextModelContract.new_consulting_3_quarter ?? Decimal.Zero,
                  Consult4Quarter = dataContextModelContract.new_consulting_4_quarter ?? Decimal.Zero,
                  NewServiceYear = dataContextModelContract.new_service_year ?? Decimal.Zero,//переходящие сервис
                  NewConsultYear = dataContextModelContract.new_consulting_year ?? Decimal.Zero, ////переходящие консалтин
                  NewProductTotalConsult = dataContextModelContract.new_product_sum_consulting ?? Decimal.Zero,
                  NewProductTotalService = dataContextModelContract.new_product_sum_service ?? Decimal.Zero,
                  FloatingContractsYearTotal = dataContextModelContract.new_year_sum ?? Decimal.Zero, // Итого по году cервис переходящий + Консалтинг переходящий  
                  FirstQuartalTotal = (dataContextModelContract.new_service_1_quarter ?? Decimal.Zero) + (dataContextModelContract.new_consulting_1_quarter ?? Decimal.Zero),
                  SecondQuartalTotal = (dataContextModelContract.new_service_2_quarter ?? Decimal.Zero) + (dataContextModelContract.new_consulting_2_quarter ?? Decimal.Zero),
                  ThirdQuartalTotal = (dataContextModelContract.new_service_3_quarter ?? Decimal.Zero) + (dataContextModelContract.new_consulting_3_quarter ?? Decimal.Zero),
                  FourthQuartalTotal = (dataContextModelContract.new_service_4_quarter ?? Decimal.Zero) + (dataContextModelContract.new_consulting_4_quarter ?? Decimal.Zero),
                  ContractPlanId = dataContextModelContract.new_link_contract_plan_year_id ?? default(Guid)
              });
            var contracts = query.ToList();
            return contracts;
        }

        private decimal? calcQuarterTotal(decimal? servQ, decimal? consultQ)
        {
            return (servQ ?? decimal.MinValue) + (consultQ ?? decimal.MinValue);
        }

        private IList<new_contract_plan_productBase> GetDataContextModelContracts()
        {
            return Db.new_contract_plan_productBase.ToList(); ;
        }

        private new_contract_plan_productBase GetDataContextModelContract(Guid contrGuid)
        {
            return Db.new_contract_plan_productBase.FirstOrDefault(contract => contract.new_contract_plan_productId == contrGuid);
        }
    }
}