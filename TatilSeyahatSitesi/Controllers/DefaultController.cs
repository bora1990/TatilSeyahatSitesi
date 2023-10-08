using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;
using Context = TatilSeyahatSitesi.Models.Siniflar.Context;

namespace TatilSeyahatSitesi.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler=c.Blogs.OrderByDescending(x=>x.Tarih).Take(5).ToList();
            return View(degerler);
        }

        public ActionResult About() 
        {
            return View();
        }

        public ActionResult BizeUlas()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values=c.Blogs.OrderByDescending(x => x.Tarih).Take(2).ToList();

            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = c.Blogs.OrderBy(x=>x.Tarih).Take(1).ToList();


            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(10).ToList();

            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger=c.Blogs.OrderByDescending(x=>x.BegeniPuani).Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderBy(x => x.BegeniPuani).Take(3).ToList();
            return PartialView(deger);
        }
    }
}