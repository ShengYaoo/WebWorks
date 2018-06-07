using mLibrary.Database;
using System.Linq;
using System.Web.Mvc;

namespace WebWork.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var db = new mDbContext();
            var model = db.FarmTrans.ToList();
            return View(model);
            //return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}