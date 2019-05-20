using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateCode_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        public ViewResult Products()
        {
            return View();
        }

        public ViewResult Automation_Systems()
        {
            return View();
        }
        public ViewResult Web_Design()
        {
            return View();
        }
        public ViewResult Mobile_Application()
        {
            return View();
        }
        public ViewResult E_Commerce()
        {
            return View();
        }
    }
}