using System.Web.Mvc;
using AspNetWebFMvc.Models.EntityFramework;



namespace AspNetCoreWebAppMvc.Controllers
{
    public class HomeController : Controller
    {
        DbMvcOkulEntities1 db = new DbMvcOkulEntities1 ();

		public ActionResult Index()
        {
            var dersler = db.
            return View();
        }
    }
}
