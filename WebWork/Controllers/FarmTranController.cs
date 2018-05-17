using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMLanalysis.Database;

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
        public ActionResult Edit(string id)
        {
            var model = db.FarmTrans.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(string id, XMLanalysis.OpenData.FarmTran input)
        {
            var model = db.FarmTrans.Find(id);

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
        public ActionResult Delete(string id)
        {
            var model = db.FarmTrans.Find(id);
            //db.OpenDatas.Remove(model);
            //db.SaveChanges();
            return View(model);

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DoDelete(string id)
        {
            var model = db.FarmTrans.Find(id);
            db.FarmTrans.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}