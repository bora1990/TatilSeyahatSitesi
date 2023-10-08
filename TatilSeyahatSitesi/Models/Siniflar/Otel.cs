using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class Otel
    {
        [Key]
        public int ID { get; set; }

        public string OtelAdi { get; set; }

        public string OtelImage { get; set; }

        public string OtelAciklama { get; set; }

        public int BlogID { get; set; }

        public virtual Blog Blog { get; set; }

        public ICollection<OtelDetay> OtelDetay { get; set; }
    }
}