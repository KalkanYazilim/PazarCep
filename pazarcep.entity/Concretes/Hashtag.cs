using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Hashtag : IEntity
    {
        [Key]
        public int Hashtag_ID { get; set; }
        public string Hashtag_Adi { get; set; }
        public virtual int Durum_ID { get; set; }
    }
}
