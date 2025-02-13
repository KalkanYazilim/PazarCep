using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Randevu: IEntity
    {
        [Key]
        public int Randevu_ID { get; set; }
        public int Olusturan_ID { get; set; }
        public int Hedef_ID { get; set; }
        public DateTime Olusturma_Tarihi { get; set; }
        public int ilan_ID { get; set; }
        public int Yuk_ID { get; set; }
        public string Aciklama { get; set; }
        public int Durum_ID { get; set; }
    }
}
