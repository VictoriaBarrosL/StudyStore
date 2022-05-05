using Microsoft.AspNetCore.Mvc;

namespace StudyStoreApp.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
