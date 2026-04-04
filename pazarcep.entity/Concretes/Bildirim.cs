using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Bildirim : IEntity
    {
        [Key]
        public int Bildirim_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public string Tip { get; set; }
        public int ilgili_ID { get; set; }
        public DateTime Olusturma_Tarihi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
