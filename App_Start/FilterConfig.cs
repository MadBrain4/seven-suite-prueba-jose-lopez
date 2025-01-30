using System.Web;
using System.Web.Mvc;

namespace SevenSuite_Prueba_Jose_Lopez
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
