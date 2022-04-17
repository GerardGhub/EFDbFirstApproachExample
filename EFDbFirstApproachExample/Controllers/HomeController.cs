using EFDbFirstApproachExample.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproachExample.Controllers
{
    public class HomeController : Controller
    {
        [MyActionFilter]
        [MyResultFilter]
        [OutputCache(Duration = 60)]
        public ActionResult Index()
        {
            throw new Exception("Some exception for testing purpose");
            return View();
        }
    }
}



