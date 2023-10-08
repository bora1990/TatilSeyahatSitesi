using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    
    public class AdminController : Controller
    {
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
             var values= context.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult YeniBlog() 
        {
           
            return View();     
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        
        public ActionResult BlogSil(int id)
        {
            var b = context.Blogs.Find(id);
            context.Blogs.Remove(b);
            context.SaveChanges();  
            return RedirectToAction("Index");
        }

        public ActionResult BlogGuncelle(int id)         
        {
            var blog=context.Blogs.Find(id);

            return View("BlogGuncelle", blog); //blogGuncelle sayfasıyla beraber verileride getir.
        
        }
        [HttpPost]
        public ActionResult BlogGuncelle(Blog blog)
        {
            var ilgiliBlog = context.Blogs.Find(blog.ID);
            ilgiliBlog.Aciklama=blog.Aciklama;
            ilgiliBlog.Baslik=blog.Baslik;
            ilgiliBlog.BegeniPuani=blog.BegeniPuani;
            ilgiliBlog.Tarih=blog.Tarih;
            ilgiliBlog.BlogImage=blog.BlogImage;

            context.SaveChanges();

            return RedirectToAction("Index"); //blogGuncelle sayfasıyla beraber verileride getir.

        }

        public ActionResult Hakkimizda()
        {
            var value=context.Hakkimizdas.FirstOrDefault(); 

            return View(value);
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = context.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(yorum);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGuncelle(int id)
        {
            List<SelectListItem> blogBaslik = (from x in context.Blogs.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Baslik,
                                                   Value = x.ID.ToString()
                                               }).ToList();
            ViewBag.baslik = blogBaslik;

            var yorum = context.Yorumlars.Find(id);

            return View(yorum); //blogGuncelle sayfasıyla beraber verileride getir.
        }
        [HttpPost]

        public ActionResult YorumGuncelle(Yorumlar yorumlar)
        {
            var ilgiliYorum = context.Yorumlars.Find(yorumlar.ID);
            ilgiliYorum.KullaniciAdi = yorumlar.KullaniciAdi;
            ilgiliYorum.Mail = yorumlar.Mail;
            ilgiliYorum.Yorum = yorumlar.Yorum;
          
       
            context.SaveChanges();

            return RedirectToAction("YorumListesi"); 
        }

        public ActionResult OtelListele()
        {
            var values = context.Otels.ToList();
            return View(values);
     
        }
        public ActionResult OtelEkle()
        {
            List<SelectListItem> blogId = (from x in context.Blogs.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = x.Baslik,
                                                   Value = x.ID.ToString()
                                               }).ToList();
            ViewBag.blogId=blogId;

            return View();
        }

        [HttpPost]
        public ActionResult OtelEkle(Otel otel)
        {
            context.Otels.Add(otel);
            context.SaveChanges();

            return RedirectToAction("OtelListele","Admin");
        }

        public ActionResult OtelSil(int id)
        {
            var b = context.Otels.Find(id);
            context.Otels.Remove(b);
            context.SaveChanges();
            return RedirectToAction("OtelListele", "Admin"); ;
        }

        public ActionResult OtelGuncelle(int id)
        {
            List<SelectListItem> blogId = (from x in context.Blogs.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Baslik,
                                               Value = x.ID.ToString()
                                           }).ToList();
            ViewBag.blogId = blogId;
            var Otel = context.Otels.Find(id);

            return View("OtelGuncelle", Otel); //OtelGuncelle sayfasıyla beraber verileride getir.

        }
        [HttpPost]
        public ActionResult OtelGuncelle(Otel otel)
        {
            var ilgiliOtel = context.Otels.Find(otel.ID);
            ilgiliOtel.OtelAciklama = otel.OtelAciklama;
            ilgiliOtel.OtelAdi = otel.OtelAdi;


            context.SaveChanges();

            return RedirectToAction("OtelListele", "Admin"); //OtelGuncelle sayfasıyla beraber verileride getir.

        }

    }

}