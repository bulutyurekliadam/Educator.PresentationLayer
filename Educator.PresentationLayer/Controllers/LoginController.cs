using Educator.EntityLayer.Concrete;
using Educator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Educator.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]


        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Usarname, model.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "MyCourse", new {area = "Member"});
            }
            return View();
        }
    }
}
