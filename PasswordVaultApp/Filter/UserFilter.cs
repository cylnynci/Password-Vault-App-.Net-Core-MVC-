using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasswordVaultApp.Filter
{
    public class UserFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            object[] gelenController = (object[]) context.RouteData.Values.Values;
            int? UserId = context.HttpContext.Session.GetInt32("id");
            if(!UserId.HasValue)
            {
                if (gelenController[0].ToString() == "Home" && gelenController[1].ToString() == "Index")
                {
                    base.OnActionExecuting(context);
                    return;
                }
                else if (gelenController[0].ToString() == "Home" && gelenController[1].ToString() == "AddUser")
                {
                    base.OnActionExecuting(context);
                    return;
                }
                else
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary  
                {
                    {"action","Index"},
                    {"Controller","Home"}

                });
                }
            }
            else if (gelenController[0].ToString() == "Home" && gelenController[1].ToString() == "Index")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"action","AccountList"},
                    {"Controller","Account"}

                });
                return;
            }


            base.OnActionExecuting(context);    
        }
    }
}
