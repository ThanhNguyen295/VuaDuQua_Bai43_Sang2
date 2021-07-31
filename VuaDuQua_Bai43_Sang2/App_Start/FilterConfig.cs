using System.Web;
using System.Web.Mvc;

namespace VuaDuQua_Bai43_Sang2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
