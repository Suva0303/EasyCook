using Microsoft.AspNetCore.Mvc;

namespace EasyCook_8_.Models
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
