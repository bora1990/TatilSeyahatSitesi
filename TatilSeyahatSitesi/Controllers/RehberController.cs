using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{

    public class RehberController : Controller
    {
        Context context = new Context();

        public ActionResult Oteller()
        {
            var values = context.Otels.ToList();
            return View(values);
        }

        public ActionResult OtelDetay(int id)
        {
            var value = context.OtelDetays.Where(x => x.OtelID == id).ToList();
            return View(value);
        }
    }
}