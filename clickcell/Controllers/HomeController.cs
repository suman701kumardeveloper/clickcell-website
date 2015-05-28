using System.Web.Mvc;
using clickcell.Models;

namespace clickcell.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            string imageSet = "";
            const string imagePath = "/Images/clickcellsystems.gif";

            for (int i = 1; i <= 8; i++)
            {
                //imageSet += string.Format("<div class=\"image\" id=\"{1}\" path=\"{0}\">{1}</div>", imagePath, i);

            }

            return View(new HomePage(imageSet));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
