using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Xdsoft.RTK.ExtCrmWeb.ViewModels
{
    public class QueryPropertyMessage
    {
        public Action Callback { get; private set; }
        public string PropertyName { get; set; }
        public IList<decimal> RowTotals { get; set; }

        public QueryPropertyMessage(Action callback)
        {
            this.Callback = callback;
            RowTotals = new List<decimal>();
        }

    }
}