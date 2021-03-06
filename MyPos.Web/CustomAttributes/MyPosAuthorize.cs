﻿using System.Web.Mvc;

namespace MyPos.Web.CustomAttributes
{   
    public class MyPosAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (this.AuthorizeCore(filterContext.HttpContext))
            {
                base.OnAuthorization(filterContext);
            }
            else
            {
                filterContext.Result = new RedirectResult("~/Account/Login");
            }
        }
    }
}