using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Kategori: IEntity
    {
        [Key]
        public int Kategori_ID { get; set; }
        public string Kategori_Adi { get; set; }
    }
}
