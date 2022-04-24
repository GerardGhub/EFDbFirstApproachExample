using EFDbFirstApproachExample.Filters;
using Company.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.DataLayer;

namespace EFDbFirstApproachExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        [MyAuthenticationFilter]
        [CustomerAuthorization]
        [MyActionFilter]
        public ActionResult Index()
        {
            CompanyDbContext db = new CompanyDbContext();
            List<Product> products = db.Products.ToList();
            return View(products);
           
        }
        [ChildActionOnly]
        public ActionResult DisplaySingleProduct(Product p)
        {
            return PartialView("MyProduct", p);
        }
    }
}