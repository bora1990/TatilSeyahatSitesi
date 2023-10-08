using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class AboutController : Controller
    {
        Context c=new Context();
        public ActionResult Index()
        {
            var values=c.Hakkimizdas.ToList();
                  
            return View(values);
        }
    }
}