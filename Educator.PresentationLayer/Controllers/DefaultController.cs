using Educator.BusinessLayer.Abstract;
using Educator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Educator.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMailSubscribeService _mailSubscribeService;

        public DefaultController(IMailSubscribeService mailSubscribeService)
        {
            _mailSubscribeService = mailSubscribeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddMailSubscribe ()
        {
            return PartialView();
        }
        [HttpPost]
        public  IActionResult AddMailSubscribe (MailSubscribe mailSubscribe)
        {
            _mailSubscribeService.TInsert(mailSubscribe);
            return RedirectToAction("Index");
        }
            
    }
}
