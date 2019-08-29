using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.ViewModels
{
    public class IndexViewModel
    {
        public string Parenttableid { get; set; }
        public string Quarterhlight { get; set; }
        //public string Contractstatus { get; set; }

        public IndexViewModel(string parenttableid, string quarterhlight)
        {
            Parenttableid = parenttableid;
            Quarterhlight = quarterhlight;            
        }
    }
}