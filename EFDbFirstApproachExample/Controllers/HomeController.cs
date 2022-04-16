using EFDbFirstApproachExample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproachExample.Controllers
{
    [MyActionFilter]
    [MyResultFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}



