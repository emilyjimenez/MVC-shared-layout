using Microsoft.AspNetCore.Mvc;

namespace SharedLayout.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index()
      {
        return View();
      }
 }
}
