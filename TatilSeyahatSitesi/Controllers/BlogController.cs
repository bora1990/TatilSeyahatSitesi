using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();

        BlogYorum by = new BlogYorum();

        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderBy(x => x.Tarih).Take(5).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //var blogbul=c.Blogs.Where(x=>x.ID==id).ToList();  
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.BlogID == id).ToList();
            by.Deger3 = c.Blogs.OrderBy(x => x.Tarih).Take(5).ToList();
            return View(by);
        }

        public PartialViewResult YorumBolumu()
        {
            var values = c.Yorumlars.Take(5).ToList();

            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar gelenYorum)
        {
            c.Yorumlars.Add(gelenYorum);
            c.SaveChanges();
            return PartialView();
        }


    }
}