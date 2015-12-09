using System.Web.Mvc;

namespace E-learning.Web.Controllers
{
    public class HomeController : E-learningControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}