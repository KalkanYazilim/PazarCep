using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class YukAlan_Bilgisi : IEntity
    {
        [Key]
        public int YukAlan_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
    }
}
