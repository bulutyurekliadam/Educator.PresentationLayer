using Educator.EntityLayer.Concrete;
using Educator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Educator.PresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.UserName= values.UserName;
            userEditViewModel.ImageUrl= values.imageUrl;
            userEditViewModel.Email= values.Email;
            return View(userEditViewModel);  
        } 
        [HttpPost]
        
        public async Task<IActionResult> Index(UserEditViewModel  p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var ImageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + ImageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.imageUrl = "/userimages/"+ImageName;

            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.Email = p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View();

        }

       
    }
}
