using System.Web;
using System.Web.Mvc;

namespace GC_Deliverable19_Lab20_CoffeeShop_Init
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
