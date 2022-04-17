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
    [OutputCache(Duration = 60)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Some exception for testing purpose");
            return View();
        }
    }
}



