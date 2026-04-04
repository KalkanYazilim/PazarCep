using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class GonderiHashtagi : IEntity
    {
        [Key]
        public int GonderiHashtagleri_ID { get; set; }
        public virtual int Gonderi_ID { get; set; }
        public virtual int Hashtag_ID { get; set; }
    }
}
