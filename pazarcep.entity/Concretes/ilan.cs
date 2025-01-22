using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class ilan : IEntity
    {
        [Key]
        public int ilan_ID { get; set; }
        public int ilanOlusturan_ID { get; set; }
        public int Urun_ID { get; set; }
        public decimal Miktar_Ton { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Eklenme_Tarihi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
