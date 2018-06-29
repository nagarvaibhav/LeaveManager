using NLog;
using System.Web.Mvc;

namespace LeaveManager.Infrastructure.Filters
{
    public class ApplicationException : FilterAttribute, IExceptionFilter
    {
        Logger _logger = LogManager.GetCurrentClassLogger();

        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                _logger.Error(filterContext.Exception);
                filterContext.Result = new ViewResult() {ViewName ="~/Views/Shared/Error.cshtml" };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}