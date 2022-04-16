using EFDbFirstApproachExample.Filters;
using EFDbFirstApproachExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDbFirstApproachExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [MyAuthenticationFilter]
        [CustomerAuthorization]
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Product> products = db.Products.ToList();
            return View(products);
           
        }
    }
}