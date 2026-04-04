using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class PuanGecmisi : IEntity
    {
        [Key]
        public int PuanGecmisi_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public decimal Degisim_Miktari { get; set; }
        public DateTime Tarihi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
