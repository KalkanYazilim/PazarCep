namespace PazarCep.Areas.ETicaret.Models;

public static class MusteriWorkspaceFactory
{
  private static readonly IReadOnlyList<MusteriKaynakKaydi> Musteriler =
  [
    new()
    {
      Id = 1024,
      MusteriKodu = "PZC-1024",
      TamAd = "Ayşe Kaya",
      Unvan = "Kıdemli Satın Alma Yetkilisi",
      Sirket = "Kaya Restoran Grubu",
      Segment = "Kurumsal",
      Durum = "Aktif",
      DurumSinifi = "success",
      Sehir = "İstanbul / Kadıköy",
      KayitTarihi = "2024.01.14",
      SonEtkilesim = "2026.05.02 10:45",
      Email = "ayse.kaya@kayarestoran.com",
      Telefon = "+90 532 441 18 27",
      Temsilci = "Deniz Şahin",
      Abonelik = "Platin İşletme",
      Bakiye = "₺148.240",
      YasamBoyuDeger = 148240m,
      AcikSiparis = 4,
      TamamlananSiparis = 128,
      SaglikSkoru = 92,
      MemnuniyetPuani = 4.8m,
      YorumSayisi = 16,
      YonlendirmeSayisi = 7,
      Etiketler = ["VIP", "Yüksek Hacim", "B2B", "İstanbul Bölgesi"]
    },
    new()
    {
      Id = 1078,
      MusteriKodu = "PZC-1078",
      TamAd = "Murat Demir",
      Unvan = "Mağaza Sahibi",
      Sirket = "Demir Organik",
      Segment = "Sadık Perakende",
      Durum = "Büyüyor",
      DurumSinifi = "primary",
      Sehir = "Ankara / Çankaya",
      KayitTarihi = "2024.03.03",
      SonEtkilesim = "2026.05.01 16:20",
      Email = "murat@demirorganik.com",
      Telefon = "+90 541 772 66 19",
      Temsilci = "Ece Yıldırım",
      Abonelik = "Profesyonel",
      Bakiye = "₺62.800",
      YasamBoyuDeger = 62800m,
      AcikSiparis = 3,
      TamamlananSiparis = 74,
      SaglikSkoru = 86,
      MemnuniyetPuani = 4.6m,
      YorumSayisi = 11,
      YonlendirmeSayisi = 4,
      Etiketler = ["Omnichannel", "Ankara", "Sadakat Kulübü"]
    },
    new()
    {
      Id = 1091,
      MusteriKodu = "PZC-1091",
      TamAd = "Selin Aksoy",
      Unvan = "Satın Alma Müdürü",
      Sirket = "Aksoy Catering",
      Segment = "Kurumsal",
      Durum = "Takip Gerekli",
      DurumSinifi = "warning",
      Sehir = "İzmir / Bornova",
      KayitTarihi = "2024.05.18",
      SonEtkilesim = "2026.04.30",
      Email = "selin.aksoy@aksoycatering.com",
      Telefon = "+90 533 915 42 80",
      Temsilci = "Deniz Şahin",
      Abonelik = "Profesyonel",
      Bakiye = "₺41.900",
      YasamBoyuDeger = 41900m,
      AcikSiparis = 2,
      TamamlananSiparis = 49,
      SaglikSkoru = 71,
      MemnuniyetPuani = 4.3m,
      YorumSayisi = 6,
      YonlendirmeSayisi = 2,
      Etiketler = ["Ödeme Vadesi", "Kurumsal", "İzmir"]
    },
    new()
    {
      Id = 1117,
      MusteriKodu = "PZC-1117",
      TamAd = "Emre Işık",
      Unvan = "Operasyon Yöneticisi",
      Sirket = "Işık Marketler Zinciri",
      Segment = "Bölgesel Zincir",
      Durum = "Aktif",
      DurumSinifi = "success",
      Sehir = "Bursa / Nilüfer",
      KayitTarihi = "2024.06.29",
      SonEtkilesim = "2026.05.02 08:12",
      Email = "emre.isik@isikmarket.com",
      Telefon = "+90 545 612 92 73",
      Temsilci = "Burcu Tan",
      Abonelik = "Platin İşletme",
      Bakiye = "₺91.300",
      YasamBoyuDeger = 91300m,
      AcikSiparis = 5,
      TamamlananSiparis = 95,
      SaglikSkoru = 89,
      MemnuniyetPuani = 4.7m,
      YorumSayisi = 14,
      YonlendirmeSayisi = 5,
      Etiketler = ["Zincir Mağaza", "Bursa", "Yüksek Frekans"]
    },
    new()
    {
      Id = 1150,
      MusteriKodu = "PZC-1150",
      TamAd = "Zeynep Öztürk",
      Unvan = "Kurucu",
      Sirket = "Öztürk Gurme",
      Segment = "Yeni Kazanım",
      Durum = "Onboarding",
      DurumSinifi = "info",
      Sehir = "Antalya / Muratpaşa",
      KayitTarihi = "2025.02.07",
      SonEtkilesim = "2026.05.02 09:00",
      Email = "zeynep@ozturkgurme.com",
      Telefon = "+90 537 220 18 44",
      Temsilci = "Ece Yıldırım",
      Abonelik = "Başlangıç",
      Bakiye = "₺18.750",
      YasamBoyuDeger = 18750m,
      AcikSiparis = 1,
      TamamlananSiparis = 12,
      SaglikSkoru = 78,
      MemnuniyetPuani = 4.4m,
      YorumSayisi = 3,
      YonlendirmeSayisi = 1,
      Etiketler = ["Yeni Müşteri", "Antalya", "Onboarding"]
    },
    new()
    {
      Id = 1189,
      MusteriKodu = "PZC-1189",
      TamAd = "Kerem Arslan",
      Unvan = "İşletme Müdürü",
      Sirket = "Arslan Taze Ürünler",
      Segment = "Riskte",
      Durum = "Kritik",
      DurumSinifi = "danger",
      Sehir = "Adana / Seyhan",
      KayitTarihi = "2024.04.22",
      SonEtkilesim = "2026.04.27",
      Email = "kerem.arslan@arslantaze.com",
      Telefon = "+90 535 811 09 90",
      Temsilci = "Burcu Tan",
      Abonelik = "Profesyonel",
      Bakiye = "₺27.480",
      YasamBoyuDeger = 27480m,
      AcikSiparis = 1,
      TamamlananSiparis = 34,
      SaglikSkoru = 58,
      MemnuniyetPuani = 3.9m,
      YorumSayisi = 2,
      YonlendirmeSayisi = 0,
      Etiketler = ["Risk Alarmı", "Adana", "İade İzleme"]
    }
  ];

  private static readonly IReadOnlyList<MusteriDetaySekmeViewModel> Sekmeler =
  [
    new() { Anahtar = "genel-bakis", Baslik = "Genel Bakış", Action = "GenelBakis", Ikon = "bx-grid-alt" },
    new() { Anahtar = "bilgiler", Baslik = "Müşteri Bilgileri", Action = "Bilgiler", Ikon = "bx-id-card" },
    new() { Anahtar = "adres-faturalandirma", Baslik = "Adres & Faturalandırma", Action = "AdresFaturalandirma", Ikon = "bx-map" },
    new() { Anahtar = "bildirimler", Baslik = "Bildirimler", Action = "Bildirimler", Ikon = "bx-bell" },
    new() { Anahtar = "yorumlar", Baslik = "Yorum Yönetimi", Action = "YorumYonetimi", Ikon = "bx-message-square-dots" },
    new() { Anahtar = "yonlendirmeler", Baslik = "Yönlendirmeler", Action = "Yonlendirmeler", Ikon = "bx-git-branch" },
    new() { Anahtar = "guvenlik", Baslik = "Güvenlik", Action = "Guvenlik", Ikon = "bx-shield-quarter" }
  ];

  public static MusteriDizinSayfaViewModel CreateDizinPage()
  {
    return new()
    {
      SayfaBasligi = "Müşteri kontrol merkezi",
      SayfaAciklamasi = "Hesap sağlığı, ticari potansiyel ve operasyonel aksiyonları tek ekranda yönetin. Mobil görünüm için kart düzeni korunur, masaüstünde ise yüksek yoğunluklu yönetim tablosu sunulur.",
      OzetKartlar =
      [
        new() { Baslik = "Toplam müşteri", Deger = Musteriler.Count.ToString(), Aciklama = "Aktif müşteri portföyü", Ikon = "bx-group", Ton = "primary" },
        new() { Baslik = "Kurumsal hesap", Deger = Musteriler.Count(x => x.Segment.Contains("Kurumsal", StringComparison.OrdinalIgnoreCase)).ToString(), Aciklama = "B2B ve zincir işletmeler", Ikon = "bx-buildings", Ton = "info" },
        new() { Baslik = "Takip gereken", Deger = Musteriler.Count(x => x.DurumSinifi is "warning" or "danger").ToString(), Aciklama = "Risk veya özel ilgi isteyen kayıt", Ikon = "bx-error-circle", Ton = "warning" },
        new() { Baslik = "Ortalama sağlık", Deger = $"{Musteriler.Average(x => x.SaglikSkoru):N0}/100", Aciklama = "Müşteri deneyimi ve operasyon skoru", Ikon = "bx-pulse", Ton = "success" }
      ],
      HizliFiltreler = ["Tüm hesaplar", "Kurumsal", "Sadık perakende", "Riskte", "Son 7 gün aktif", "Açık siparişi olanlar"],
      Musteriler = Musteriler
        .OrderByDescending(x => x.YasamBoyuDeger)
        .Select(x => new MusteriListeSatiriViewModel
        {
          Id = x.Id,
          MusteriKodu = x.MusteriKodu,
          TamAd = x.TamAd,
          Sirket = x.Sirket,
          Email = x.Email,
          Telefon = x.Telefon,
          Segment = x.Segment,
          Durum = x.Durum,
          DurumSinifi = x.DurumSinifi,
          Sehir = x.Sehir,
          Temsilci = x.Temsilci,
          SonEtkilesim = x.SonEtkilesim,
          SonSiparis = x.AcikSiparis > 0 ? $"{x.AcikSiparis} açık sipariş" : "Açık sipariş yok",
          YasamBoyuDeger = $"₺{x.YasamBoyuDeger:N0}",
          MemnuniyetPuani = $"{x.MemnuniyetPuani:N1}/5",
          AcikSiparis = x.AcikSiparis.ToString()
        })
        .ToList()
    };
  }

  public static MusteriGenelBakisSayfaViewModel CreateGenelBakisPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "genel-bakis", "Genel Bakış", "Hesabın ticari performansını, son aktiviteleri ve operasyonel odağı yönetin."),
      PerformansKartlari =
      [
        new() { Baslik = "Yaşam boyu değer", Deger = $"₺{musteri.YasamBoyuDeger:N0}", Aciklama = "Son 12 ay toplam katkı", Ikon = "bx-wallet", Ton = "success" },
        new() { Baslik = "Tamamlanan sipariş", Deger = musteri.TamamlananSiparis.ToString(), Aciklama = "Teslim edilen sipariş adedi", Ikon = "bx-package", Ton = "primary" },
        new() { Baslik = "Memnuniyet puanı", Deger = $"{musteri.MemnuniyetPuani:N1}/5", Aciklama = "Yorum ve NPS birleşik skor", Ikon = "bx-star", Ton = "warning" },
        new() { Baslik = "İlişki skoru", Deger = $"{musteri.SaglikSkoru}/100", Aciklama = "Risk, ödeme ve etkileşim dengesi", Ikon = "bx-line-chart", Ton = "info" }
      ],
      SonAktiviteler =
      [
        new() { Baslik = "Teklif güncellendi", Aciklama = $"{musteri.Sirket} için haftalık meyve-sebze kotasyonu revize edildi.", Zaman = "2026.05.02 10:20", Ikon = "bx-receipt", Ton = "primary" },
        new() { Baslik = "Sipariş onaylandı", Aciklama = "Teslimat penceresi 07:00 - 09:00 olarak sabitlendi.", Zaman = "2026.05.02 08:45", Ikon = "bx-check-circle", Ton = "success" },
        new() { Baslik = "Temsilci notu", Aciklama = $"{musteri.Temsilci} ödeme vadesi revizyonu için geri dönüş bekliyor.", Zaman = "2026.05.01 17:30", Ikon = "bx-note", Ton = "warning" },
        new() { Baslik = "Sadakat avantajı atandı", Aciklama = "Platin segmentte ek indirim eşiği aktive edildi.", Zaman = "2026.04.30", Ikon = "bx-gift", Ton = "info" }
      ],
      HesapSagligi =
      [
        new() { Baslik = "Sipariş ritmi", Deger = "Stabil", Aciklama = "Son 6 haftada planlı sipariş düzeni korunuyor.", Ton = "success" },
        new() { Baslik = "Ödeme davranışı", Deger = "Kontrollü", Aciklama = "Ortalama vade uyumu %94 seviyesinde.", Ton = musteri.DurumSinifi is "danger" ? "danger" : "primary" },
        new() { Baslik = "Destek ihtiyacı", Deger = "Düşük", Aciklama = "Açık destek kaydı bulunmuyor, yalnızca temsilci notu var.", Ton = "info" },
        new() { Baslik = "Büyüme fırsatı", Deger = "Yüksek", Aciklama = "Ek kategori açılımı ve çapraz satış potansiyeli mevcut.", Ton = "warning" }
      ],
      SonSiparisler =
      [
        new() { SiparisNo = "SC-58421", Tarih = "2026.04.21", Kanal = "Mobil", Tutar = "₺12.450", Durum = "Teslimat hazırlanıyor", DurumSinifi = "info" },
        new() { SiparisNo = "SC-58390", Tarih = "2026.04.18", Kanal = "Müşteri temsilcisi", Tutar = "₺9.180", Durum = "Tamamlandı", DurumSinifi = "success" },
        new() { SiparisNo = "SC-58277", Tarih = "2026.04.15", Kanal = "Web", Tutar = "₺6.940", Durum = "Tamamlandı", DurumSinifi = "success" }
      ]
    };
  }

  public static MusteriBilgilerSayfaViewModel CreateBilgilerPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "bilgiler", "Müşteri Bilgileri", "Kimlik, sözleşme, iletişim ve operasyonel sahiplik verilerini tek doğruluk kaynağında toplayın."),
      DurumKartlari =
      [
        new() { Baslik = "Hesap sahibi", Deger = musteri.Temsilci, Aciklama = "Birincil ilişki yöneticisi", Ikon = "bx-user-pin", Ton = "primary" },
        new() { Baslik = "Abonelik paketi", Deger = musteri.Abonelik, Aciklama = "Güncel ticari paket", Ikon = "bx-badge-check", Ton = "success" },
        new() { Baslik = "Müşteri segmenti", Deger = musteri.Segment, Aciklama = "Ticari sınıflandırma", Ikon = "bx-category-alt", Ton = "info" }
      ],
      BilgiGruplari =
      [
        new()
        {
          Baslik = "Hesap kimliği",
          Aciklama = "Müşteri kaydı ve ticari profil temel alanları.",
          Alanlar =
          [
            new() { Etiket = "Müşteri kodu", Deger = musteri.MusteriKodu },
            new() { Etiket = "Tam ad", Deger = musteri.TamAd },
            new() { Etiket = "Ünvan", Deger = musteri.Unvan },
            new() { Etiket = "Şirket", Deger = musteri.Sirket },
            new() { Etiket = "Segment", Deger = musteri.Segment },
            new() { Etiket = "Durum", Deger = musteri.Durum },
            new() { Etiket = "Kayıt tarihi", Deger = musteri.KayitTarihi },
            new() { Etiket = "Son temas", Deger = musteri.SonEtkilesim }
          ]
        },
        new()
        {
          Baslik = "İletişim ve operasyon",
          Aciklama = "Müşteriye ulaşım, teslimat koordinasyonu ve çalışma tercihleri.",
          Alanlar =
          [
            new() { Etiket = "E-posta", Deger = musteri.Email },
            new() { Etiket = "Telefon", Deger = musteri.Telefon },
            new() { Etiket = "Şehir / bölge", Deger = musteri.Sehir },
            new() { Etiket = "Çalışma saatleri", Deger = "Hafta içi 07:00 - 18:00", YardimMetni = "Teslimat talebi için en yoğun pencere 08:00 - 11:00." },
            new() { Etiket = "Sipariş kanalı", Deger = "Mobil + temsilci", YardimMetni = "Rutin siparişler mobil, kritik siparişler temsilci üzerinden açılıyor." },
            new() { Etiket = "Teslimat önceliği", Deger = "Sabah ilk dağıtım", YardimMetni = "Soğuk zincir ürünlerinde sabit rota önceliği aktif." }
          ]
        },
        new()
        {
          Baslik = "Sözleşme ve ticari notlar",
          Aciklama = "Ödeme, indirim, SLA ve ticari mutabakat notları.",
          Alanlar =
          [
            new() { Etiket = "Ödeme vadesi", Deger = "14 gün", YardimMetni = "Kurumsal anlaşma kapsamında tanımlı." },
            new() { Etiket = "İskonto seviyesi", Deger = "%8 operasyonel indirim" },
            new() { Etiket = "SLA paketi", Deger = "Aynı gün geri dönüş", YardimMetni = "Kritik talepler için 2 saat içinde yanıt hedefi." },
            new() { Etiket = "Muhasebe notu", Deger = "E-fatura entegrasyonu aktif", GridSinifi = "col-12" }
          ]
        }
      ],
      Yetkililer =
      [
        new() { AdSoyad = musteri.TamAd, Rol = musteri.Unvan, Email = musteri.Email, Telefon = musteri.Telefon, Durum = "Birincil kişi", DurumSinifi = "success" },
        new() { AdSoyad = "Fatma Kaya", Rol = "Muhasebe sorumlusu", Email = "muhasebe@" + musteri.Email.Split('@')[1], Telefon = "+90 530 221 40 50", Durum = "Faturalandırma", DurumSinifi = "info" },
        new() { AdSoyad = "Mehmet Öz", Rol = "Operasyon koordinatörü", Email = "operasyon@" + musteri.Email.Split('@')[1], Telefon = "+90 536 701 09 14", Durum = "Teslimat", DurumSinifi = "primary" }
      ]
    };
  }

  public static MusteriAdresFaturalandirmaSayfaViewModel CreateAdresFaturalandirmaPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "adres-faturalandirma", "Adres & Faturalandırma", "Teslimat adreslerini, e-fatura tercihlerini ve ödeme operasyonunu tek ekranda yönetin."),
      Adresler =
      [
        new() { Baslik = "Merkez teslimat", Tip = "Varsayılan teslimat", Alici = musteri.Sirket, AdresSatiri = "Caferağa Mah. Moda Cad. No:18", IlceIl = musteri.Sehir, VergiBilgisi = "Teslimat notu: Soğuk zincir ayrı girişten alınır.", Not = "Hafta içi 07:00 öncesi sevkiyat kabul edilir.", Varsayilan = true },
        new() { Baslik = "Depo adresi", Tip = "Yedek teslimat", Alici = musteri.Sirket + " Depo", AdresSatiri = "Hasanpaşa Mah. Kurbağalıdere Sok. No:9", IlceIl = musteri.Sehir, VergiBilgisi = "Palet teslimatı için rampa erişimi mevcut.", Not = "Yüksek hacimli siparişlerde otomatik yönlendirilir.", Varsayilan = false }
      ],
      FaturaPanelleri =
      [
        new()
        {
          Baslik = "Faturalandırma profili",
          Aciklama = "Muhasebe akışı ve belge üretim tercihleri.",
          Alanlar =
          [
            new() { Etiket = "Belge tipi", Deger = "E-fatura" },
            new() { Etiket = "Fatura periyodu", Deger = "Sipariş bazlı" },
            new() { Etiket = "Muhasebe e-postası", Deger = "muhasebe@" + musteri.Email.Split('@')[1] },
            new() { Etiket = "Vergi dairesi", Deger = "Kadıköy VD" },
            new() { Etiket = "Vergi numarası", Deger = "1234567890" },
            new() { Etiket = "Ödeme yöntemi", Deger = "Kurumsal havale" }
          ]
        },
        new()
        {
          Baslik = "Operasyonel kontroller",
          Aciklama = "Risk, limit ve mutabakat alanları.",
          Alanlar =
          [
            new() { Etiket = "Kredi limiti", Deger = "₺180.000" },
            new() { Etiket = "Kullanılan bakiye", Deger = musteri.Bakiye },
            new() { Etiket = "Mutabakat sıklığı", Deger = "Aylık" },
            new() { Etiket = "Ödeme disiplini", Deger = "Düzenli", YardimMetni = "Son üç dönemde gecikme görülmedi." }
          ]
        }
      ],
      SonFaturalar =
      [
        new() { FaturaNo = "EF-2026-0421", Tutar = "₺12.450", Vade = "2026.05.05", Yontem = "Havale", Durum = "Planlandı", DurumSinifi = "info" },
        new() { FaturaNo = "EF-2026-0405", Tutar = "₺9.180", Vade = "2026.04.19", Yontem = "Havale", Durum = "Ödendi", DurumSinifi = "success" },
        new() { FaturaNo = "EF-2026-0328", Tutar = "₺6.940", Vade = "2026.04.11", Yontem = "Havale", Durum = "Ödendi", DurumSinifi = "success" }
      ]
    };
  }

  public static MusteriBildirimlerSayfaViewModel CreateBildirimlerPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "bildirimler", "Bildirimler", "Kanal bazlı tercihleri, operasyonel uyarıları ve son gönderimleri görünür hale getirin."),
      KanalKartlari =
      [
        new() { Baslik = "E-posta kapsamı", Deger = "18 aktif akış", Aciklama = "Sipariş, fatura ve güvenlik bildirimleri", Ikon = "bx-envelope", Ton = "primary" },
        new() { Baslik = "SMS önceliği", Deger = "Kritik olaylar", Aciklama = "Teslimat gecikmesi ve güvenlik alarmı", Ikon = "bx-message-dots", Ton = "warning" },
        new() { Baslik = "Push / uygulama", Deger = "Açık", Aciklama = "Mobil uygulama bildirimleri aktif", Ikon = "bx-mobile-alt", Ton = "success" }
      ],
      TercihGruplari =
      [
        new()
        {
          Baslik = "Sipariş ve operasyon",
          Aciklama = "Sipariş akışı boyunca müşteri ve ekiplerin aldığı uyarılar.",
          Tercihler =
          [
            new() { Baslik = "Sipariş onayı", Aciklama = "Yeni sipariş oluşturulduğunda gönderilir.", Eposta = true, Sms = false, Push = true, Uygulama = true },
            new() { Baslik = "Teslimat gecikmesi", Aciklama = "Rota veya stok kaynaklı kritik gecikmeler.", Eposta = true, Sms = true, Push = true, Uygulama = true },
            new() { Baslik = "Stok alternatifi", Aciklama = "Ürün değişikliği gerektiğinde aksiyon ister.", Eposta = true, Sms = false, Push = true, Uygulama = true }
          ]
        },
        new()
        {
          Baslik = "Finans ve hesap",
          Aciklama = "Fatura, mutabakat ve sözleşme akışları.",
          Tercihler =
          [
            new() { Baslik = "Fatura oluşturuldu", Aciklama = "E-fatura üretildiğinde muhasebe ekibine iletilir.", Eposta = true, Sms = false, Push = false, Uygulama = true },
            new() { Baslik = "Vade yaklaşımı", Aciklama = "Ödeme vadesinden 3 gün önce hatırlatma gönderilir.", Eposta = true, Sms = true, Push = false, Uygulama = true },
            new() { Baslik = "Sözleşme yenileme", Aciklama = "Paket veya fiyat sözleşmesi bitiş bildirimi.", Eposta = true, Sms = false, Push = true, Uygulama = true }
          ]
        }
      ],
      SonBildirimler =
      [
        new() { Baslik = "Teslimat slotu onaylandı", Kanal = "Uygulama", Durum = "İletildi", DurumSinifi = "success", Tarih = "2026.05.02 09:12", Ozet = "Sabah sevkiyat planı müşteri tarafından onaylandı." },
        new() { Baslik = "Yeni fatura yayınlandı", Kanal = "E-posta", Durum = "Okundu", DurumSinifi = "info", Tarih = "2026.05.01 16:48", Ozet = "Nisan ikinci yarı siparişleri için e-fatura teslim edildi." },
        new() { Baslik = "Vade hatırlatması", Kanal = "SMS", Durum = "Beklemede", DurumSinifi = "warning", Tarih = "2026.04.20", Ozet = "Vadesi yaklaşan ödeme için zamanlanmış hatırlatma." }
      ]
    };
  }

  public static MusteriYorumYonetimiSayfaViewModel CreateYorumYonetimiPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "yorumlar", "Yorum Yönetimi", "Müşterinin ürün yorumlarını, moderasyon kararlarını ve güven sinyallerini kontrollü biçimde yönetin."),
      ModerasyonKartlari =
      [
        new() { Baslik = "Toplam yorum", Deger = musteri.YorumSayisi.ToString(), Aciklama = "Son 12 ay yayınlanan yorumlar", Ikon = "bx-message-square-detail", Ton = "primary" },
        new() { Baslik = "Yayın bekleyen", Deger = "2", Aciklama = "Elle onay gerektiren kayıtlar", Ikon = "bx-time-five", Ton = "warning" },
        new() { Baslik = "Yanıtlanan", Deger = "11", Aciklama = "Marka ekibi tarafından cevaplanan yorumlar", Ikon = "bx-check-double", Ton = "success" }
      ],
      Yorumlar =
      [
        new() { Urun = "Organik Domates", Kanal = "Mobil uygulama", Tarih = "2026.04.20", Puan = 5, Baslik = "Kalite çok tutarlı", Icerik = "Teslimat erken geldi, ürün kalitesi beklediğimiz standardı korudu.", Durum = "Yayında", DurumSinifi = "success", ModerasyonNotu = "Öne çıkarılabilir yorum." },
        new() { Urun = "Köy Yumurtası", Kanal = "Web", Tarih = "2026.04.17", Puan = 3, Baslik = "Paketleme geliştirilmeli", Icerik = "İçerik iyi ancak koli içinde daha sabitlenmiş olmasını beklerdik.", Durum = "İncelemede", DurumSinifi = "warning", ModerasyonNotu = "Operasyon ekibi yanıt hazırlıyor." },
        new() { Urun = "Çiğ Badem", Kanal = "Müşteri temsilcisi", Tarih = "2026.04.12", Puan = 4, Baslik = "Fiyat / kalite dengesi iyi", Icerik = "Kurumsal siparişlerde tekrar değerlendireceğiz, genel deneyim olumlu.", Durum = "Yanıtlandı", DurumSinifi = "info", ModerasyonNotu = "Satış ekibi çapraz satış önerisi ile dönüş yaptı." }
      ]
    };
  }

  public static MusteriYonlendirmelerSayfaViewModel CreateYonlendirmelerPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "yonlendirmeler", "Yönlendirmeler", "Yönlendirme performansını, ödül akışını ve yeni hesap kazanım etkisini ölçülebilir hale getirin."),
      ProgramKartlari =
      [
        new() { Baslik = "Aktif yönlendirme", Deger = musteri.YonlendirmeSayisi.ToString(), Aciklama = "Takip edilen yönlendirme adedi", Ikon = "bx-git-compare", Ton = "primary" },
        new() { Baslik = "Dönüşen hesap", Deger = "3", Aciklama = "Kayıt ve ilk siparişi tamamlayan hesap", Ikon = "bx-trending-up", Ton = "success" },
        new() { Baslik = "Hak edilen ödül", Deger = "₺4.500", Aciklama = "Cari dönemde oluşan teşvik bakiyesi", Ikon = "bx-award", Ton = "warning" }
      ],
      Yonlendirmeler =
      [
        new() { AdSoyad = "Nil Yılmaz", Kanal = "Referans kodu", KayitDurumu = "İlk sipariş tamamlandı", DurumSinifi = "success", Tarih = "2026.04.19", DonusumDegeri = "₺1.850", Not = "Meyve kategorisinde yüksek hacim potansiyeli var." },
        new() { AdSoyad = "Mavera Şarküteri", Kanal = "Temsilci yönlendirmesi", KayitDurumu = "Teklif sürecinde", DurumSinifi = "info", Tarih = "2026.04.15", DonusumDegeri = "Bekleniyor", Not = "Muhasebe evrak onayı bekleniyor." },
        new() { AdSoyad = "Rota Cafe", Kanal = "QR kampanyası", KayitDurumu = "İletişim kuruldu", DurumSinifi = "warning", Tarih = "2026.04.11", DonusumDegeri = "Ön potansiyel", Not = "İlk deneme siparişi için kampanya talebi var." }
      ],
      ProgramAdimlari =
      [
        new() { Baslik = "Referans tanımlandı", Aciklama = "Müşteriye özel kod ve takip bağlantısı aktif.", Durum = "Tamamlandı", DurumSinifi = "success" },
        new() { Baslik = "Potansiyel adaylar izlendi", Aciklama = "Açılış, tıklama ve temsilci geri dönüşleri birleştirildi.", Durum = "Aktif", DurumSinifi = "primary" },
        new() { Baslik = "Ödül mutabakatı", Aciklama = "İlk sipariş tamamlanan hesaplar için cari teşvik hesaplanıyor.", Durum = "Planlandı", DurumSinifi = "warning" }
      ]
    };
  }

  public static MusteriGuvenlikSayfaViewModel CreateGuvenlikPage(int? id)
  {
    var musteri = ResolveCustomer(id);

    return new()
    {
      Kabuk = BuildShell(musteri, "guvenlik", "Güvenlik", "Kimlik doğrulama, oturum yönetimi ve denetim kayıtlarını güven odaklı bir iş akışında görünür tutun."),
      RiskKartlari =
      [
        new() { Baslik = "Risk skoru", Deger = $"{100 - Math.Max(8, 100 - musteri.SaglikSkoru)}/100", Aciklama = "Oturum, cihaz ve davranış sinyallerinden türetildi", Ikon = "bx-shield", Ton = musteri.DurumSinifi is "danger" ? "danger" : "success" },
        new() { Baslik = "Çok adımlı doğrulama", Deger = "Zorunlu", Aciklama = "Yönetici oturumları için aktif", Ikon = "bx-lock-alt", Ton = "success" },
        new() { Baslik = "Açık oturum", Deger = "3 cihaz", Aciklama = "Son 30 günde aktif cihazlar", Ikon = "bx-devices", Ton = "info" }
      ],
      Kontroller =
      [
        new() { Baslik = "Parola politikası", Aciklama = "90 günde bir yenileme ve güçlü parola zorunluluğu aktif.", Durum = "Uyumlu", DurumSinifi = "success", EylemMetni = "Politikayı görüntüle" },
        new() { Baslik = "Yetkisiz oturum takibi", Aciklama = "Yeni cihaz girişlerinde anlık alarm ve temsilci bildirimi açık.", Durum = "İzleniyor", DurumSinifi = "info", EylemMetni = "Alarm ayarları" },
        new() { Baslik = "İşlem onayı", Aciklama = "Kritik adres ve fatura değişiklikleri ikinci onay gerektiriyor.", Durum = "Güçlü", DurumSinifi = "primary", EylemMetni = "Onay akışını incele" }
      ],
      Oturumlar =
      [
        new() { Cihaz = "MacBook Pro · Chrome", Konum = "İstanbul", IpAdresi = "78.189.24.18", SonAktivite = "2026.05.02 10:10", MevcutOturum = true },
        new() { Cihaz = "iPhone 15 · iOS App", Konum = "İstanbul", IpAdresi = "176.42.10.77", SonAktivite = "2026.05.02 07:34", MevcutOturum = false },
        new() { Cihaz = "Windows 11 · Edge", Konum = "Ankara", IpAdresi = "95.70.121.33", SonAktivite = "2026.04.18", MevcutOturum = false }
      ],
      DenetimKayitlari =
      [
        new() { Baslik = "MFA doğrulandı", Aciklama = "Yönetici oturumu başarılı ikinci faktör doğrulamasıyla açıldı.", Zaman = "2026.05.02 09:58", Ton = "success" },
        new() { Baslik = "Yeni cihaz girişi", Aciklama = "Ankara konumundan Edge tarayıcısı ile giriş yapıldı.", Zaman = "2026.04.18", Ton = "warning" },
        new() { Baslik = "Fatura adresi değişikliği", Aciklama = "İkinci onay akışı ile tamamlandı, log kaydı oluşturuldu.", Zaman = "2026.04.11", Ton = "info" }
      ]
    };
  }

  private static MusteriDetayKabukViewModel BuildShell(MusteriKaynakKaydi musteri, string aktifSekme, string sayfaBasligi, string sayfaAciklamasi)
  {
    return new()
    {
      Id = musteri.Id,
      MusteriKodu = musteri.MusteriKodu,
      TamAd = musteri.TamAd,
      Unvan = musteri.Unvan,
      Sirket = musteri.Sirket,
      Segment = musteri.Segment,
      Durum = musteri.Durum,
      DurumSinifi = musteri.DurumSinifi,
      Sehir = musteri.Sehir,
      KayitTarihi = musteri.KayitTarihi,
      SonEtkilesim = musteri.SonEtkilesim,
      Email = musteri.Email,
      Telefon = musteri.Telefon,
      Temsilci = musteri.Temsilci,
      Abonelik = musteri.Abonelik,
      Bakiye = musteri.Bakiye,
      SayfaBasligi = sayfaBasligi,
      SayfaAciklamasi = sayfaAciklamasi,
      AktifSekme = aktifSekme,
      Etiketler = musteri.Etiketler,
      HeroKartlari =
      [
        new() { Baslik = "Sağlık skoru", Deger = $"{musteri.SaglikSkoru}/100", Aciklama = "İlişki ve işlem kalitesi", Ikon = "bx-heart-circle", Ton = "success" },
        new() { Baslik = "Açık sipariş", Deger = musteri.AcikSiparis.ToString(), Aciklama = "Operasyon takibindeki işler", Ikon = "bx-cart", Ton = "primary" },
        new() { Baslik = "Toplam değer", Deger = $"₺{musteri.YasamBoyuDeger:N0}", Aciklama = "Yaşam boyu ciro katkısı", Ikon = "bx-lira", Ton = "warning" },
        new() { Baslik = "Yönlendirme", Deger = musteri.YonlendirmeSayisi.ToString(), Aciklama = "Aktif referans programı", Ikon = "bx-share-alt", Ton = "info" }
      ],
      Sekmeler = Sekmeler
    };
  }

  private static MusteriKaynakKaydi ResolveCustomer(int? id)
  {
    return Musteriler.FirstOrDefault(x => x.Id == id) ?? Musteriler[0];
  }

  private sealed class MusteriKaynakKaydi
  {
    public required int Id { get; init; }
    public required string MusteriKodu { get; init; }
    public required string TamAd { get; init; }
    public required string Unvan { get; init; }
    public required string Sirket { get; init; }
    public required string Segment { get; init; }
    public required string Durum { get; init; }
    public required string DurumSinifi { get; init; }
    public required string Sehir { get; init; }
    public required string KayitTarihi { get; init; }
    public required string SonEtkilesim { get; init; }
    public required string Email { get; init; }
    public required string Telefon { get; init; }
    public required string Temsilci { get; init; }
    public required string Abonelik { get; init; }
    public required string Bakiye { get; init; }
    public required decimal YasamBoyuDeger { get; init; }
    public required int AcikSiparis { get; init; }
    public required int TamamlananSiparis { get; init; }
    public required int SaglikSkoru { get; init; }
    public required decimal MemnuniyetPuani { get; init; }
    public required int YorumSayisi { get; init; }
    public required int YonlendirmeSayisi { get; init; }
    public required IReadOnlyList<string> Etiketler { get; init; }
  }
}
