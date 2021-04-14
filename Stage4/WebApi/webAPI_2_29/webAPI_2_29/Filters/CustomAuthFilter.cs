using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI_2_29.Filters
{
    public class CustomAuthFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                StringValues value;
                if (context.HttpContext.Request.Headers.TryGetValue("Authorization", out value))
                {
                    if(value.ToString().Contains("Bearer")) base.OnActionExecuting(context);

                    else context.Result = new BadRequestObjectResult("Invalid Request - Token present but bearer unavailable");
                }
                
            }
            else
            {
                context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
            }

            base.OnActionExecuting(context);
            
        }
    }
}
