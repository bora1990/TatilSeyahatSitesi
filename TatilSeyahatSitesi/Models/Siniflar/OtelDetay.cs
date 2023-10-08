using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class OtelDetay
    {
        [Key]
        public int ID { get; set; }

        public string Resim1 { get; set; }
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }

        public int OtelID { get; set; }
        public virtual Otel Otel { get; set; }
        
    }
}