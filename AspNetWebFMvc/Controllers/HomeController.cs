using Microsoft;

namespace AspNetCoreWebAppMvc.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
        {
            return View();
        }
    }
}
