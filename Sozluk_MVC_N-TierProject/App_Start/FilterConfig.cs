using System.Web;
using System.Web.Mvc;

namespace Sozluk_MVC_N_TierProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
