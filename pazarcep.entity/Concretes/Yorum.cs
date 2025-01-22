using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Yorum : IEntity
    {
        [Key]
        public int Yorum_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public virtual int Gonderi_ID { get; set; }
        public string Metin { get; set; }
        public DateTime Olusturma_Tarihi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
