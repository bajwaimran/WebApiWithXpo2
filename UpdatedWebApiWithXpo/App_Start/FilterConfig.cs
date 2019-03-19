using System.Web;
using System.Web.Mvc;

namespace UpdatedWebApiWithXpo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
