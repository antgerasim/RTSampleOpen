using System.Web;
using System.Web.Mvc;

namespace Xdsoft.RTK.ExtCrmWeb {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}