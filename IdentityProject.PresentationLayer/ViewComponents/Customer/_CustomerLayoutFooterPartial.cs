﻿using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
