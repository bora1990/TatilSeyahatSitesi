using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public int Aciklama { get; set; }
    }
}