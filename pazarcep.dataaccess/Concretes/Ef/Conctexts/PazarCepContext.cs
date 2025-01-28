using Microsoft.EntityFrameworkCore;
using pazarcep.entity.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.dataaccess.Concretes.Ef.Conctexts
{
    public class PazarCepContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"workstation id=PazerCep_DB.mssql.somee.com;packet size=4096;user id=KalkanYAZILIM_SQLLogin_1;pwd=e65ywzzxv9;data source=PazerCep_DB.mssql.somee.com;persist security info=False;initial catalog=PazerCep_DB;TrustServerCertificate=True");
        }

        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Begeni> Begeniler { get; set; }
        public DbSet<Bildirim> Bildirimler { get; set; }
        public DbSet<Ciftci_Bilgisi> Ciftci_Bilgileri { get; set; }
        public DbSet<Durum> Durumlar { get; set; }
        public DbSet<Gonderi> Gonderiler { get; set; }
        public DbSet<GonderiHashtagi> GonderiHashtagleri { get; set; }
        public DbSet<Hashtag> Hashtagler { get; set; }
        public DbSet<ilan> ilanlar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Mesaj> Mesajlar { get; set; }
        public DbSet<Puanlar> Puanlar { get; set; }
        public DbSet<PuanGecmisi> PuanGecmisleri { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
        public DbSet<SonSatici> SonSaticilar { get; set; }
        public DbSet<Takipci> Takipciler { get; set; }
        public DbSet<Tasimaci_Bilgisi> Tasimaci_Bilgileri { get; set; }
        public DbSet<Teslimat_Durumu> Teslimat_Durumlari { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Yuk> Yukler { get; set; }
        public DbSet<YukAlan_Bilgisi> YukAlan_Bilgileri { get; set; }
        public DbSet<YukVeren_Bilgisi> YukVeren_Bilgileri { get; set; }
        //Bütün tabloların DbSet i yapılacak.
    }
}
