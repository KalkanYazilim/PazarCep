using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.entity.Concretes
{
    public class Kullanici : IEntity
    {
        [Key]
        public int Kullanici_ID { get; set; }
        public string Kullanici_Adi { get; set; }
        public string E_Mail { get; set; }
        public string Sifre { get; set; }
        public string TC_No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Rol { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string Mahalle_Koy { get; set; }
        public string Cadde_Sokak { get; set; }
        public DateTime Kayit_Tarihi { get; set; }
        public int Durum_ID { get; set; }
        public string Resim_Yolu { get; set; }
    }
}
