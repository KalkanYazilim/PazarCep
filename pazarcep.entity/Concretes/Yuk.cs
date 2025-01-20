using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Ciftci_Bilgisi : IEntity
    {
        [Key]
        public int Arac_ID { get; set; }
        public string Arac_Adi { get; set; }

        public string Arac_Plaka { get; set; }
        public string Arac_Turu { get; set; }
        public decimal Tasima_Kapasitesi { get; set; }
        public bool Sogutucu { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
