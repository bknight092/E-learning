using System.Web.Mvc;

namespace ELearning.Web.Controllers
{
    public class HomeController : ELearningControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}