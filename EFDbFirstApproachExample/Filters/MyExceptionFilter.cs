using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproachExample.Filters
{
    public class MyExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            string s = "Message: " + filterContext.Exception.Message + ", Type: " + filterContext.Exception.GetType().ToString() + ", Source: " + filterContext.Exception.Source;
            StreamWriter sw = File.AppendText(filterContext.RequestContext.HttpContext.Request.PhysicalApplicationPath + "\\ErrorLog.txt");
            sw.WriteLine(s);
            sw.Close();
            //filterContext.ExceptionHandled = true;
            //filterContext.Result = new RedirectResult("~/Error.html");
        }
    }
}