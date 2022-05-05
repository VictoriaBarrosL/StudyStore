using Microsoft.AspNetCore.Mvc;

namespace StudyStoreApp.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
