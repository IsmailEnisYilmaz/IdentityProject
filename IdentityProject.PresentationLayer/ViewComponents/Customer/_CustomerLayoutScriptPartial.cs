using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
