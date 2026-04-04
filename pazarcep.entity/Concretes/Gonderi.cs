using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Gonderi : IEntity
    {
        [Key]
        public int Gonderi_ID { get; set; }
        public virtual string Kullanici_ID { get; set; }
        public string Metin { get; set; }
        public string MedyaYolu { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
