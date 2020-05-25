﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADKZProject.Models
{
    public class ADKZAuthority: AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)
                || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true))
            {
                return;
            }
            if (filterContext.HttpContext.Session["LoginName"] == null || filterContext.HttpContext.Session["LoginName"].ToString() == "")
            {
                HttpContext.Current.Response.Write("Inadmissibility");
                HttpContext.Current.Response.End();
                filterContext.Result = new RedirectResult("/Home/ManagerRegister");
            }
        }
    }
}