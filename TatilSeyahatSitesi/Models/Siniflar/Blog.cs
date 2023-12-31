﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string City { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public int BegeniPuani { get; set; }    
        public string BlogImage { get; set; }

        public ICollection<Yorumlar> Yorumlars { get; set; }
        public ICollection<Otel> Otellers { get; set; }
        
    }
}