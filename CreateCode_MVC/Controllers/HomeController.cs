using System.Web.Mvc;
using CreateCode_MVC.Models;

namespace CreateCode_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult HomePage()
        {
            var kullanicilar = new Kullanici() {UserId=1,UserName="Selman",UserSurname="KOYAN",UserMail="selman-619@hotmail.com",UserNickName="resistablee",UserPassword="85231"};
            return View(kullanicilar);
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult LoginIn()
        {
            return View();
        }

        public ViewResult SignUp()
        {
            return View();
        }
    }
}