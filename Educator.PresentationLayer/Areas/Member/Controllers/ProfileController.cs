﻿using Educator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Educator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(values);
        }
    }
}
