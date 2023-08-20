using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.PresentationLayer.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
