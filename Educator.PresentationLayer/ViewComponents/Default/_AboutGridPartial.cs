﻿using Educator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.ViewComponents.Default
{
    public class _AboutGridPartial : ViewComponent
    {
        private readonly IAboutGridService _aboutGridService;
        public _AboutGridPartial(IAboutGridService aboutGridService)
        {
            _aboutGridService = aboutGridService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _aboutGridService.TGetList();
            return View(values);
        }
    }
}
