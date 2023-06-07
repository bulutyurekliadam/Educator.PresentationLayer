using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Controllers
{
	public class SweetAlertController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
