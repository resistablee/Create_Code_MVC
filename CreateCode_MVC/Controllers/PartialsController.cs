using System.Web.Mvc;

namespace CreateCode_MVC.Controllers
{
    public class PartialsController : Controller
    {
        // GET: Partials
        public PartialViewResult _Logo()
        {
            return PartialView();
        }

        public PartialViewResult _Menu()
        {
            return PartialView();
        }
    }
}