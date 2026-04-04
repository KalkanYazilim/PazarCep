using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Urun : IEntity
    {
        [Key]
        public int Urun_ID { get; set; }
        public virtual int Ciftci_ID { get; set; }
        public string Urun_Adi { get; set; }
        public string Urun_Kategorisi { get; set; }
        public string Urun_Tipi { get; set; }
        public virtual int Kategori_ID { get; set; }
        public int Durum_ID { get; set; }
    }
}
