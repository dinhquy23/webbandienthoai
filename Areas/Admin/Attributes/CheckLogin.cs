using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
namespace Project.Areas.Admin.Attributes
{
    public class CheckLogin:ActionFilterAttribute
    {
        public HttpContext _httpContext => new HttpContextAccessor().HttpContext;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string _email = _httpContext.Session.GetString("email");
            if(string.IsNullOrEmpty(_email))
            {
                _httpContext.Response.Redirect("/Admin/Account/Login");
            }
            base.OnActionExecuting(context);
        }
    }
}
