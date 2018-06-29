using LeaveManager.Infrastructure.Filters;
using System.Web.Mvc;

namespace LeaveManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ApplicationException());
        }
    }
}
