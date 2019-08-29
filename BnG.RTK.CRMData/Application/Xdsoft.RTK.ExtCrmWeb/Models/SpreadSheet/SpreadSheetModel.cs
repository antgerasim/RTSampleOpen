using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.Models.SpreadSheet
{
    public class SpreadSheetModel
    {
        public bool IsReadOnly { get; set; }
        public byte[] Body { get; set; }
    }
}