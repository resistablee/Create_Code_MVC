using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateCode_MVC.Controllers
{
    public class LessonsController : Controller
    {
        // GET: Lessons

        public ViewResult Lessons()
        {
            return View();
        }
        
        public ViewResult CSharp()
        {
            return View();
        }
        public ViewResult Python()
        {
            return View();
        }
        public ViewResult ASPDotNet()
        {
            return View();
        }
    }
}