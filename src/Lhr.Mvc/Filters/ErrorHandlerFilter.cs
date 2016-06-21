using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Filters;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Routing;
using Lhr.Mvc.Services.Session;

namespace Lhr.Mvc.Filters
{
    public class LhrErrorLoggingAttribute : ActionFilterAttribute, IExceptionFilter
    {
        bool RedirectToSelf = false;
        ISessionService Session = null;
        public LhrErrorLoggingAttribute(bool redirectToSelf, ISessionService sessionService)
        {
            RedirectToSelf = redirectToSelf;
            Session = sessionService;
        }
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            RouteData routeDate = context.RouteData;
            string controllerName = routeDate.Values["controller"].ToString();
            string actionName = routeDate.Values["action"].ToString();
            string errorMessage = $@"<h3>Error details</h3>
                        <div class='errorPath'>[ {controllerName} ] / [ {actionName} ] / [ {context.HttpContext.Request.QueryString} ]</div>
                        <div class='errorMessage'>{context.Exception.GetType().ToString()} / {context.Exception.Message}</div>
                        <pre class='errrorStackTrace'>{context.Exception.StackTrace}</pre>";
            SessionData sessionData = Session.GetData();
            sessionData.ErrorMessage = errorMessage;
            Session.SaveData(sessionData);
            if (RedirectToSelf)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                    {
                        {"controller", controllerName},
                        {"action", actionName}
                    });
            }
            else
            {
                context.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }
        }
    }
}
