﻿using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.PresentationLayer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
