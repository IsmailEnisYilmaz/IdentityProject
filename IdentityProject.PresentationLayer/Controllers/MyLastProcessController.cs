using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.PresentationLayer.Controllers
{
    public class MyLastProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
