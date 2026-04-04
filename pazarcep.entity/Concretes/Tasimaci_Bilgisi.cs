using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Tasimaci_Bilgisi : IEntity
    {
        [Key]
        public int Tasimaci_ID { get; set; }
        public virtual string Kullanici_ID { get; set; }
        public virtual string Arac_ID { get; set; }
    }
}
