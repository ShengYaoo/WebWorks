using mLibrary.Database;
using mLibrary.OpenData;
using System.Linq;
using System.Web.Mvc;
namespace WebWork.Controllers
{
    public class FarmTranController : Controller
    {
        // GET: FarmTran
        mDbContext db = new mDbContext();
        public ActionResult Index()
        {

            var models = db.FarmTrans
                .ToList();
            return View(models);
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var model = db.FarmTrans.Find(Id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int Id, FarmTran input)
        {
            var model = db.FarmTrans.Find(Id);

            model.marketCode = input.marketCode;
            model.marketName = input.marketName;
            model.priceAvg = input.priceAvg;
            model.priceHigh = input.priceHigh;
            model.priceMid = input.priceMid;
            model.priceLow = input.priceLow;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult goDelete(int Id)
        {
            var model = db.FarmTrans.Find(Id);
            return View(model);

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete(int Id)
        {
            var model = db.FarmTrans.Find(Id);
            db.FarmTrans.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}