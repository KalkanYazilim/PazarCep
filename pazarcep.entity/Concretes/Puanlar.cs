using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Puanlar : IEntity
    {
        [Key]
        public int Kullanici_ID { get; set; }
        public string Puan { get; set; }
        public DateTime Guncelleme_Tarihi { get; set; }
    }
}
