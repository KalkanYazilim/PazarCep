using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Teslimat_Durumu : IEntity
    {
        [Key]
        public int Teslimat_ID { get; set; }
        public virtual int Tasimaci_ID { get; set; }
        public virtual int Yuk_ID { get; set; }
        public virtual int Gonderen_ID { get; set; }
        public decimal Alici_ID { get; set; }
        public DateTime Teslimat_Tarihi { get; set; }
        public virtual int Durum_ID { get; set; }
        public virtual int Randevu_ID { get; set; }
    }
}
