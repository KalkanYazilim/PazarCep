using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class SonSatici : IEntity
    {
        [Key]
        public int SonSatici_ID { get; set; }
        public virtual int Kullanici_ID { get; set; }
        public string FirmaAdi { get; set; }
        public string VergiNumarasi { get; set; }
    }
}
