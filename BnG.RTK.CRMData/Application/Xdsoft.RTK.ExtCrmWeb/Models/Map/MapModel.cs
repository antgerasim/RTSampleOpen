using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    //public class MapModel : ReportModel
    public class MapModel 

    {
        // public SubjectModel SubjectMdl { get; set; }
        //public ReportModel ReportMdl { get; set; }
        public int SubjectCode { get; set; }
        public string SubjectName { get; set; }
        //public int SubjectCode { get; set; }
        //public GeoModel GeoMdl { get; set; }
        public string SubjectCoordinates { get; set; }

        public dynamic ReportData { get; set; }
        //public int ReportData { get; set; }
        //public dynamic ReportData { get; set; }

    }
}