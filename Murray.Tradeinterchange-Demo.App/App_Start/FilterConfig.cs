using System.Web;
using System.Web.Mvc;

namespace Murray.Tradeinterchange_Demo.App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
