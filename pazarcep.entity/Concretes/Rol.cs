using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Rol : IEntity
    {
        [Key]
        public int Rol_ID { get; set; }
        public string Rol_Adi { get; set; }
    }
}
