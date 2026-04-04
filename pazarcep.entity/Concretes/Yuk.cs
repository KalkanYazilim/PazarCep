using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Yuk : IEntity
    {
        [Key]
        public int Yuk_ID { get; set; }
        public virtual int YukVeren_ID { get; set; }
        public string Yuk_Adi { get; set; }
        public decimal Miktar_Ton { get; set; }
        public string Konum_Baslangic { get; set; }
        public string Konum_Bitis { get; set; }
        public DateTime Olusturma_Tarihi { get; set; }
        public virtual int Urun_ID { get; set; }
        public virtual int TasimaDurum_ID { get; set; }
    }
}
