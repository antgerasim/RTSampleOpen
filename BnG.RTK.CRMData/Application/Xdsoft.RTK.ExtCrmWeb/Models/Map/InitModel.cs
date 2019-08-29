using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class InitModel
    {
        //public IEnumerable<MapModel> MapModels { get; set; }
        public IEnumerable<dynamic> MapModels { get; set; }

        public IEnumerable<ProductCatalogModel> ProductCatalog { get; set; }

       // public IList<SuccessStoryModel> SuccessStoryModels { get; set; }

        public string ReportType { get; set; }
    }
}