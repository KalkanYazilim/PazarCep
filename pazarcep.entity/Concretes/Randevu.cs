using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Randevu : IEntity
    {
        [Key]
        public int Randevu_ID { get; set; }
        public virtual int Olusturan_ID { get; set; }
        public virtual int Hedef_ID { get; set; }
        public DateTime Olusturma_Tarihi { get; set; }
        public virtual int ilan_ID { get; set; }
        public virtual int Yuk_ID { get; set; }
        public string Aciklama { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
