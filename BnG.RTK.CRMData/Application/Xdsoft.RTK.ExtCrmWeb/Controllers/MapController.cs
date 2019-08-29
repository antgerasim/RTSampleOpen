using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Xdsoft.RTK.ExtCrmWeb.Data;
using Xdsoft.RTK.ExtCrmWeb.Models.Map;
using NetTopologySuite.Geometries;

namespace Xdsoft.RTK.ExtCrmWeb.Controllers
{
    public class MapController : Controller
    {

        RTCRM Db = new RTCRM();

        public List<Point> SubjectPoints { get; private set; }

        // GET: Map
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Choropleth()
        {
            return View();
        }

        public ActionResult MapPanes()
        {
            return View();
        }

        public ActionResult GeoJsonBasic()
        {
            //https://leafletjs.com/examples/geojson/
            return View();
        }

        public ActionResult LayersControl()
        {
            return View();
        }

        public ActionResult Alpha()
        {
            #region OLD SQL
            //var foo = Db.new_t_projectBase.Select(p => p.new_territoryBase.new_name).Count();
            /****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
            //            SELECT
            //            --[new_t_projectId]
            //                  --,new_t_project.CreatedOn

            //      new_territory.new_name territory_name

            //   --   ,new_t_project.[statuscode]
            //      --,new_t_project.[VersionNumber]
            //      --,new_t_project.[ImportSequenceNumber]
            //      --,new_t_project.[OverriddenCreatedOn]
            //      --,new_t_project.[TimeZoneRuleVersionNumber]
            //      --,new_t_project.[UTCConversionTimeZoneCode]
            //      --,[new_project_name]
            //      --,[new_project_type]
            //      --,[new_description]
            //      --,[new_control_center]
            //      --,[TransactionCurrencyId]
            //      --,[ExchangeRate]
            //      --,[new_fact_dt_st]
            //      --,[new_dt_st_plan]
            //      --,[new_dt_end_plan]
            //      --,[new_dt_end_fact]
            //      --,[new_project_team]
            //      --,[new_project_initiative_project]
            //      --,[new_next_milestone]
            //      --,[new_link_department_project]
            //      --,[new_profitable_budget]
            //      --,[new_expendable_budget_OPEX]
            //      --,[new_expendable_budget_CAPEX]
            //      --,[new_link_milestone_Id]
            //      --,[new_link_curator_Id]
            //      --,[new_IRR]
            //      --,[new_NPV]
            //      --,[new_link_sphere_of_activity_Id]
            //      --,[new_link_territory_project]
            //      --,[new_link_account_Id]
            //      --,[new_Milestone_Type]
            //	  ,COUNT(new_territory.new_name) project_count

            //  FROM[RTPROJECTS_MSCRM].[dbo].[new_t_projectBase] as new_t_project

            //INNER JOIN[RTPROJECTS_MSCRM].[dbo].[new_territoryBase] as new_territory ON new_t_project.new_link_territory_project = new_territory.new_territoryId
            //WHERE new_t_project.statuscode = 1

            #endregion           

            return View(getProjectsPerSubjectRf(false));
        }

        public ActionResult Alpha2()
        {
            var dummyList = new List<MapModel>();
            return View(dummyList);
        }

        public ActionResult Alpha3()
        {
            return View();
        }

        public ActionResult Alpha4()
        {
            return View();
        }

        public ActionResult Beta()
        {
            return View();
        }

        public ActionResult MaxBounds()
        {
            return View();
        }

        public ActionResult DropDown(string reporttype, string productId)
        {
            if (string.IsNullOrEmpty(reporttype))
            {
                reporttype = "projectcount";
            }

            IEnumerable<ReportModel> reportData = new List<ReportModel>();
            switch (reporttype.ToLower())
            {
                case "projectcount":
                    reportData = getProjectsPerSubjectRf(false);
                    return View(GetInitModel(reportData, reporttype.ToLower(), false));
              
                case "productreadiness":
                    var defaultProductId = string.IsNullOrEmpty(productId) ? new Guid("7B3E1BCF-CB1B-E811-80CA-D3E9C8E3E880") : new Guid(productId);
                    
                    if (!string.IsNullOrEmpty(productId))
                    {
                        reportData = getProductReadinessTable(new Guid(productId), false);
                    }
                    
                    return View(GetInitModel(reportData, reporttype.ToLower(), false));
              
                case "successstory":
                    reportData = getSuccessStoryTable();
                    var test = GetInitModel(reportData, reporttype.ToLower(), false);
                    return View(test);
                case "risks":
                    reportData = getRiskTableBySubject();
                    var test2 = GetInitModel(reportData, reporttype.ToLower(), false);
                    return View(test2);
                case "deadlines":
                    reportData = getDeadlinesBySubject();
                    var test3 = GetInitModel(reportData, reporttype.ToLower(), false);
                    return View(test3);
                default:
                    break;
            }
            return View(GetGeoModelsRussianRegionsCode());
        }

        private IEnumerable<ReportModel> getDeadlinesBySubject()
        {
            var query = from territory in Db.new_territoryBase.DefaultIfEmpty()
                        select territory;
            var tableResult = query
                .Select(st => new ReportModel
                {
                    SubjectCode = st.new_kd_territory ?? default(int),
                    SubjectName = st.new_name,
                    ReportData = new Subject
                    {
                        Name = st.new_name,
                        Code = st.new_kd_territory ?? default(int),
                        Projects = st.new_t_projectBase
                        .Where(p => p.statuscode == 1)
                        .Select(p => new Project
                        {
                            Name = p.new_project_name,
                            Description = p.new_description,
                            Type = p.new_project_type,
                            Tasks = p.new_t_project_taskBase
                            .Where(task => task.new_priznak_etapa == 100000001) //only with priznak etapa = yes
                            
                            .Select(task => new Task
                            {
                                Id = task.new_t_project_taskId,
                                Name = task.new_task_name ?? default(string),
                                Content = task.new_task_content ?? default(string),
                                PlanStartDate = task.new_dt_st_plan ?? default(DateTime),
                                PlanEndDate = task.new_dt_complete_plan ?? default(DateTime),
                                FactStartDate = task.new_dt_st_fact ?? default(DateTime),
                                FactEndDate = task.new_dt_complete_fact ?? default(DateTime)
                            }).ToList()
                        }).ToList()
                    }
                }).ToList();

            var testSubjectAltaikrai = tableResult.Find(rm => rm.SubjectCode == 22);

            return tableResult;
        }

        private IEnumerable<ReportModel> getRiskTableBySubject()
        {
            var query = from territory in Db.new_territoryBase.DefaultIfEmpty()
                        select territory;

            var riskTblResult = query.Select(t => new ReportModel
            {
                SubjectCode = t.new_kd_territory ?? default(int), //must for GetProjectRisks() proper working

                ReportData = new Subject
                {
                    Name = t.new_name,
                    Code = t.new_kd_territory ?? default(int),
                    Projects = t.new_t_projectBase.Select(p => new Project
                    {
                       
                        Name = p.new_project_name,
                        Description = p.new_description,
                        Type = p.new_project_type,
                        Risks = p.new_t_project_riskBase.Select(r => new Risk
                        {
                            Name = r.new_name,
                            
                            Impact = r.new_assessment_influence_risk.ToString() ?? default(string),
                   
                            Probability = r.new_assessment_probability_risk.ToString() ?? default(string),
                            DetectionDate = r.new_dt_detection ?? default(DateTime),
                            RespAction = r.new_response_measure.ToString() ?? default(string),
                            Status = r.statuscode.ToString() ?? default(string)
                        }).ToList()
                    }).ToList()
                }
            }).ToList();

            return riskTblResult;
        }

        private IList<ReportModel> getProjectsPerSubjectRf(bool isRandomData)
        {
            var countR = new Random();
           
            var query = (from new_t_project in Db.new_t_projectBase

                         join new_territory in Db.new_territoryBase.DefaultIfEmpty() on new_t_project.new_link_territory_project equals new_territory.new_territoryId
                         where new_t_project.statuscode == 1
                         group new_territory by new { new_territory.new_name, new_territory.new_kd_territory }
                         into g
                     
                         select new ReportModel
                         {
                             SubjectCode = g.Key.new_kd_territory.Value,                             
                             ReportData = new { ProjectCount = g.Count(p => p.new_name != null) }
                         });
            var retVal = query.ToList();

            return retVal;
        }

        [HttpPost]
        public JsonResult GetProjectDataPost(string reportType, string productId)
        {
            
            IEnumerable<ReportModel> reportData = new List<ReportModel>();
            var genericResult = default(dynamic);
            switch (reportType.ToLower())
            {
                case "projectcount":                    
                    reportData = getProjectsPerSubjectRf(false);
                    genericResult = new { ReportData = reportData, ReportType = reportType };
                    return Json(genericResult);
                
                case "productreadiness":
                    var productGuid = new Guid(productId);
                    var defaultProductId = string.IsNullOrEmpty(productId) ? new Guid("7B3E1BCF-CB1B-E811-80CA-D3E9C8E3E880") : productGuid;
                    reportData = getProductReadinessTable(defaultProductId, false);
                    var productCatalog = getProductCatalog();
                    var productName = productCatalog.Where(pc => pc.ProductId == new Guid(productId)).FirstOrDefault();                   
                    var lastProjectName = reportData.Count() > 0 ? reportData.OrderByDescending(x => x.ReportData.ProjectDateCreated).FirstOrDefault().ReportData.ProjectName : "Имя последнего проекта отсутствует"; // order reportdata by date and take latest project_name
                    genericResult = new { ReportData = reportData, ProductCatalog = productCatalog, ChoosenProduct = productName, LastProjectName = lastProjectName };
                    return Json(genericResult);               
                default:
                    break;
            }

            return Json(reportData);
        }

        private IEnumerable<ProductCatalogModel> getProductCatalog()
        {

            var productList = Db.new_d_product_catalogBase
                .Where(x => !string.IsNullOrEmpty(x.new_name))
                .Select(x => new ProductCatalogModel()
                {
                    ProductName = x.new_name,
                    ProductId = x.new_d_product_catalogId
                }).ToList();
            return productList;
        }

        private IEnumerable<ReportModel> getProductReadinessTable(Guid productId, bool isRandomData)
        {
            var countR = new Random();

            var query = (from new_product_of_project in Db.new_product_of_projectBase
                         join new_t_project in Db.new_t_projectBase.DefaultIfEmpty() on new_product_of_project.new_link_project_Id equals new_t_project.new_t_projectId
                         join new_territory in Db.new_territoryBase.DefaultIfEmpty() on new_t_project.new_link_territory_project equals new_territory.new_territoryId
                         join new_d_product_catalog in Db.new_d_product_catalogBase.DefaultIfEmpty() on new_product_of_project.new_link_product_Id equals new_d_product_catalog.new_d_product_catalogId
                         join accountCat in Db.AccountBase.DefaultIfEmpty() on new_t_project.new_link_account_Id equals accountCat.AccountId
                         where new_product_of_project.new_link_product_Id == productId
                         select new ReportModel
                         {
                             SubjectCode = new_territory.new_kd_territory.Value,

                             ReportData = new
                             {
                                 ProductName = new_d_product_catalog.new_name,
                                 ProjectName = new_t_project.new_project_name,
                                 ProductReadiness = new_t_project.statuscode.Value,                                 
                                 ProjectDateCreated = new_t_project.CreatedOn.Value,
                                 ProjectDescription = new_t_project.new_description,
                                 TotalNoTax = new_t_project.new_profitable_budget.HasValue ? new_t_project.new_profitable_budget.Value : 0,
                                 Client = accountCat.Name
                             }                          

                         });
            var retVal = query.ToList();
            return retVal;
        }

        private IEnumerable<ReportModel> getSuccessStoryTable()
        {
            var query = from new_successful_project_history in Db.new_successful_project_historyBase
                        select new_successful_project_history;

            var foo = query.Select(x => new ReportModel
            {
                SubjectCode = x.new_territoryBase.new_kd_territory ?? default(int),
                ReportData = new SuccessStoryModel
                {
                    SuccessStory = x.new_name,
                    ProblemSolved = x.new_problem,
                    AchivedResult = x.new_result,
                    ProjectDescription = x.new_project_description,
                    SubjectName = x.new_territoryBase.new_name,
                    ProjectName = x.new_t_projectBase.new_project_name,
                    SphereOfActivity = x.new_d_sphere_of_activityBase.new_name,
                    ProductNames = x.new_successful_project_history_productBase.Select(y => new SuccessStorySubProductNameModel
                    {
                        ProductId = y.new_d_product_catalogBase.new_d_product_catalogId,
                        ProductName = y.new_d_product_catalogBase.new_name
                    }).ToList()
                }
            }).ToList();
            return foo;
         
        }


        private IList<GeoModel> GetGeoModelsRussianRegionsCode()
        {
            string jsonResult = ReadJsonFromFile("~\\JsonData\\russian-regions-code.json");
            var jTokenList = JObject.Parse(jsonResult).Children().ToList();
            var geoModelList = new List<GeoModel>();
            foreach (var jToken in jTokenList)
            {
                JProperty jprop = jToken.ToObject<JProperty>();
                var subjectCode = default(int);
                try
                {
                    subjectCode = (int)jToken.First["1"];
                }
                catch (Exception)
                {
                    //                    
                }
                var subjectName = jprop.Name;
                var subjectCoordinates = jToken.First["0"].ToString(); 
                geoModelList.Add(new GeoModel
                {
                    SubjectCode = subjectCode,
                    SubjectName = subjectName,
                    SubjectCoordinates = subjectCoordinates
                });
            }
            return geoModelList;
        }

        private InitModel GetInitModel(IEnumerable<ReportModel> reportDataList, string reportType, bool isRandomData)
        {
            string jsonResult = ReadJsonFromFile("~\\JsonData\\russian-regions-code.json");
            var jTokenList = JObject.Parse(jsonResult).Children().ToList();
       
            List<dynamic> mapModelGeoList = new List<dynamic>();
            Random r = new Random();

            foreach (var jToken in jTokenList)
            {
                JProperty jprop = jToken.ToObject<JProperty>();
                var SubjectCode = default(int);
                try
                {
                    SubjectCode = (int)jToken.First["1"];
                }
                catch (Exception)
                {
                    //                    
                }
                var SubjectName = jprop.Name;
                var SubjectCoordinates = jToken.First["0"].ToString(); //try to Object                

                var ReportData = default(dynamic);
                switch (reportType.ToLower())
                {
                    case "projectcount":
                        ReportData = new { ProjectCount = GetProjectCount(reportDataList, SubjectCode) };
                        break;
                    case "productreadiness":                        
                        ReportData = new { ProductReadiness = GetProductReadiness(reportDataList, SubjectCode) };

                        break;
                    case "successstory":
                        ReportData = GetSuccessStory(reportDataList, SubjectCode);
                        break;
                    case "risks":
                        ReportData = GetProjectRisks(reportDataList, SubjectCode);
                        break;
                    case "deadlines":
                        ReportData = GetProjectDeadlines(reportDataList, SubjectCode);
                        break;
                    default:
                        break;
                }

                mapModelGeoList.Add(new
                {
                    SubjectCode,
                    SubjectName,
                    SubjectCoordinates,
                    ReportData
                });
            }
           
            var initModel = new InitModel() { MapModels = mapModelGeoList, ProductCatalog = getProductCatalog(), ReportType = reportType };
      
            return initModel;
        }
        private dynamic GetProjectDeadlines(IEnumerable<ReportModel> reportModels, int subjectCode)
        {
            foreach (var rModel in reportModels)
            {
                if (rModel.SubjectCode == subjectCode)
                {
                    return rModel.ReportData;
                }
            }
            return default(dynamic);
        }

        private dynamic GetProjectRisks(IEnumerable<ReportModel> reportModels, int subjectCode)
        {

            foreach (var rModel in reportModels)
            {
                if (rModel.SubjectCode == subjectCode)
                {
                    return rModel.ReportData;
                }
            }
            return default(dynamic);
        }
        private int GetProjectCount(IEnumerable<ReportModel> reportModels, int subjectCode)
        {

            foreach (var rModel in reportModels)
            {
                if (rModel.SubjectCode == subjectCode)
                    return rModel.ReportData.ProjectCount;
            }
            return default(int);
        }

        private int GetProductReadiness(IEnumerable<ReportModel> reportModels, int subjectCode)
        {

            foreach (var rModel in reportModels)
            {
                if (rModel.SubjectCode == subjectCode)
                    return rModel.ReportData.ProductReadiness;
            }
            return default(int);
        }

        private IList<dynamic> GetSuccessStory(IEnumerable<ReportModel> reportModels, int subjectCode)
        {
            var list = new List<dynamic>();
            foreach (var rModel in reportModels)
            {
                if (rModel.SubjectCode == subjectCode)
                {
                    list.Add(rModel);
                }
            }
            return list;
        }


        private static string ReadJsonFromFile(string path)
        {
            var JsonFilePath = System.Web.HttpContext.Current.Request.MapPath(path);
            System.IO.StreamReader file = new System.IO.StreamReader(JsonFilePath);
            string content = file.ReadToEnd();
            file.Close();
            return content;
        }
    }
}





