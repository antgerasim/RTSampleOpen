using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class GeoModel
    {
        public string SubjectName { get; set; }
        public int SubjectCode { get; set; }
        public string SubjectCoordinates { get; set; }
        public IList<DonPoint> SubjectPoints { get; set; }
    }
}