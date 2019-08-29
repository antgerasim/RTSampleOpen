using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.Map
{
    public class Project
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? Type { get; set; }
        public IEnumerable<Risk> Risks { get; set; }
        public IEnumerable<Task> Tasks { get; set; }

    }
}