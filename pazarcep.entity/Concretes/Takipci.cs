using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Takipci : IEntity
    {
        [Key]
        public int Takip_ID { get; set; }
        public virtual int TakipEdilen_ID { get; set; }
        public virtual int TakipEden_ID { get; set; }
        public DateTime Takip_Tarihi { get; set; }
    }
}
