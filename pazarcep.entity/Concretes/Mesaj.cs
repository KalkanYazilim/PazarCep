using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Mesaj : IEntity
    {
        [Key]
        public int Mesaj_ID { get; set; }
        public int Gonderen_ID { get; set; }
        public int Alici_ID { get; set; }
        public string Metin { get; set; }
        public DateTime Gonderim_Tarihi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
