using System.Web.Mvc;

namespace Meerkatalyst.Demo.ASPnet.Controllers
{
  [HandleError]
  public class HomeController : Controller
  {
    public ViewResult Index()
    {
      ViewData["Message"] = "Welcome to 'Deployment as a Service' with Meerkatalyst!";

      return View();
    }
  }
}
