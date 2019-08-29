using DevExpress.Spreadsheet;
using DevExpress.Web.Mvc;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Configuration;
using System.Linq;
using System.ServiceModel.Description;
using System.Web.Mvc;
using Xdsoft.RTK.CRMData.Entities;
using Xdsoft.RTK.ExtCrmWeb.Models.SpreadSheet;

namespace Xdsoft.RTK.ExtCrmWeb.Controllers
{
    public class SpreadSheetController : Controller
    {
        private IOrganizationService CreateOrganizationService()
        {
            var organizationUri = ConfigurationManager.AppSettings["CRMUrl"];
            ClientCredentials clientCredentials = new ClientCredentials();
            clientCredentials.Windows.ClientCredential.UserName = ConfigurationManager.AppSettings["username"];
            clientCredentials.Windows.ClientCredential.Password = ConfigurationManager.AppSettings["password"];
            clientCredentials.Windows.ClientCredential.Domain = ConfigurationManager.AppSettings["domain"];
            OrganizationServiceProxy proxy = new OrganizationServiceProxy(new Uri(organizationUri), null, clientCredentials, null);
            proxy.EnableProxyTypes();
            return proxy;
        }
        private Annotation GetAnnotation(CrmServiceContext context, Guid? valuationId, out new_project_initiative_valuation valuation)
        {
            valuation = null;
            if (valuationId != null && valuationId.HasValue)
            {
                valuation = context.new_project_initiative_valuationSet.FirstOrDefault(e => e.new_project_initiative_valuationId == valuationId);
                if (valuation != null)
                {
                    context.LoadProperty(valuation, "new_project_initiative_valuation_Annotations");
                    return valuation.new_project_initiative_valuation_Annotations == null ? null : valuation.new_project_initiative_valuation_Annotations.FirstOrDefault();
                }
            }
            return null;
        }
        private Annotation GetDefaultSettingAnnotation(CrmServiceContext context)
        {
            new_setting setting = context.new_settingSet.FirstOrDefault(e => e.new_key == "ProjectCalculationExcelTemplate");
            if (setting != null)
            {
                context.LoadProperty(setting, "new_setting_Annotations");
                return setting.new_setting_Annotations == null ? null : setting.new_setting_Annotations.FirstOrDefault();
            }
            return null;
        }
        private byte[] GetAnnotationBody(IOrganizationService orgService, Annotation annotation)
        {
            if (annotation != null)
            {
                ColumnSet columnSet = new ColumnSet();
                columnSet.AddColumns(Annotation.Fields.AnnotationId, Annotation.Fields.DocumentBody);
                Entity annotationEntity = orgService.Retrieve(Annotation.EntityLogicalName, annotation.Id, columnSet);
                object documentBody = annotationEntity[Annotation.Fields.DocumentBody];
                return documentBody == null || string.IsNullOrEmpty((string)documentBody) ? null : Convert.FromBase64String((string)documentBody);
            }
            return null;
        }
        public ActionResult Index(Guid? entityId)
        {
            IOrganizationService orgSerivce = CreateOrganizationService();
            CrmServiceContext context = new CrmServiceContext(orgSerivce);
            new_project_initiative_valuation valuation = null;
            Annotation annotation = GetAnnotation(context, entityId, out valuation);
            annotation = annotation ?? GetDefaultSettingAnnotation(context);
            SpreadSheetModel spreadSheetModel = new SpreadSheetModel()
            {
                Body = GetAnnotationBody(orgSerivce, annotation),
                IsReadOnly = valuation != null && valuation.StatusCodeEnum == new_project_initiative_valuation_StatusCode.Neaktivnye
            };

            return View(spreadSheetModel);
        }
        public ActionResult SpreadSheetPartial()
        {
            return PartialView("SpreadSheetPartial");
        }
        public ActionResult Custom(Guid? entityId)
        {
            SpreadSheetModel spreadSheetModel = new SpreadSheetModel();
            if (entityId != null && entityId.HasValue)
            {
                IOrganizationService orgSerivce = CreateOrganizationService();
                CrmServiceContext context = new CrmServiceContext(orgSerivce);
                new_project_initiative_valuation valuation = null;
                Annotation annotation = GetAnnotation(context, entityId, out valuation);
                spreadSheetModel.IsReadOnly = valuation != null && valuation.StatusCodeEnum == new_project_initiative_valuation_StatusCode.Neaktivnye;
                spreadSheetModel.Body = SpreadsheetExtension.GetCurrentDocument("SpreadSheetEditor").SaveDocument(DocumentFormat.Xlsx);
                string documentBody = Convert.ToBase64String(spreadSheetModel.Body);
                if (annotation == null)
                {
                    orgSerivce.Create(new Annotation()
                    {

                        ObjectId = new EntityReference(new_project_initiative_valuation.EntityLogicalName, entityId.Value),
                        ObjectTypeCode = new_project_initiative_valuation.EntityLogicalName,
                        MimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        FileName = "[Project Calculation].xlsx",
                        DocumentBody = documentBody
                    });
                }
                else
                {
                    annotation.DocumentBody = documentBody;
                    context.UpdateObject(annotation);
                    context.SaveChanges();
                }
            }
            return PartialView("SpreadSheetPartial", spreadSheetModel);
        }
    }
}