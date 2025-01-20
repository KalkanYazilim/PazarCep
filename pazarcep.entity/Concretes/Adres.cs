using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Adres : IEntity
    {
        [Key]
        public int Adres_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string Mahalle_Koy { get; set; }
        public string Cadde_Sokak { get; set; }
    }
}
