using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Topzone.Models;

namespace Topzone.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product/Random
        public ActionResult Random()
        {
            var product = new Product() { ProductName = "Iphone 15"};
            return View(product);
        }
        public ActionResult Edit(int id) 
        {
            return Content("id=" + id);
        }
        //Product
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        public ActionResult byCategory(int CategoryID)
        {
            return Content("CategoryID = "+CategoryID);
        }
    }
}