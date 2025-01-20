using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Durum : IEntity
    {
        [Key]
        public int Durum_ID { get; set; }
        public string Durum_Adi { get; set; }
    }
}
