using System.Web;
using System.Web.Mvc;

namespace ParallelProgramming.WebB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
