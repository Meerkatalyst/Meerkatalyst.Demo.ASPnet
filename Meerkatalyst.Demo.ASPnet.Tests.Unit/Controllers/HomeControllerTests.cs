using Meerkatalyst.Demo.ASPnet.Controllers;
using NUnit.Framework;

namespace Meerkatalyst.Demo.ASPnet.Tests.Unit.Controllers
{
  [TestFixture]
  public class HomeControllerTests
  {
    [Test]
    public void Index_returns_welcome_message()
    {
      HomeController controller = new HomeController();
      var result = controller.Index();

      Assert.That(result.ViewData["Message"], Is.EqualTo("Welcome to 'Deployment as a Service' with Meerkatalyst!"));
    }
  }
}