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
        public int Ciftci_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public string Urun_Listesi { get; set; }
    }
}
