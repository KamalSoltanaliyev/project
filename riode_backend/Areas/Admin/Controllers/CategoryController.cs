using Microsoft.AspNetCore.Mvc;

namespace riode_backend.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
