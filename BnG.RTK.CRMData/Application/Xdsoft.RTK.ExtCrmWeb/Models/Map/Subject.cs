using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class Subject
    {
        public string Name { get; set; }
        public int? Code { get; set; }

        public IEnumerable<Project> Projects  { get; set; }
    }
}