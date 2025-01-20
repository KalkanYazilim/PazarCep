using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Begeni : IEntity
    {
        [Key]
        public int Begeni_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public virtual int Gonderi_ID { get; set; }
        public virtual int Yorum_ID { get; set; }
        public DateTime Begeni_Tarihi { get; set; }
       
    }
}
