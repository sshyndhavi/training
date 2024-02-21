using System.Web;
using System.Web.Mvc;

namespace CASCADING_DROPDOWN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
