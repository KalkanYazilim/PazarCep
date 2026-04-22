namespace PazarCep.Areas.Egitim.Models;

public sealed class EgitimOzetKartViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ikon { get; init; }
}

public sealed class EgitimUyariViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Ton { get; init; }
  public required string EylemMetni { get; init; }
  public required string EylemLinki { get; init; }
}

public sealed class EgitimAktiviteViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Zaman { get; init; }
  public required string Ikon { get; init; }
}

public sealed class EgitimKursSatiriViewModel
{
  public required int Id { get; init; }
  public required string KursAdi { get; init; }
  public required string Egitmen { get; init; }
  public required string Seviye { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Ozet { get; init; }
  public required string Sure { get; init; }
  public required string SonGuncelleme { get; init; }
  public required string Moduller { get; init; }
  public required string IlerlemeMetni { get; init; }
  public required int IlerlemeYuzde { get; init; }
}

public sealed class EgitimBolumViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string DersSayisi { get; init; }
  public required string Tamamlanma { get; init; }
  public required string Ton { get; init; }
}

public sealed class EgitimDersViewModel
{
  public required int Id { get; init; }
  public required string Baslik { get; init; }
  public required string Sure { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Ozet { get; init; }
  public bool Tamamlandi { get; init; }
}

public sealed class EgitimSertifikaViewModel
{
  public required string Baslik { get; init; }
  public required string Kurum { get; init; }
  public required string Tarih { get; init; }
  public required string Kod { get; init; }
  public required string Kapsam { get; init; }
}

public sealed class EgitimOzetSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<EgitimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<EgitimUyariViewModel> Uyarilar { get; init; }
  public required IReadOnlyList<EgitimAktiviteViewModel> Aktiviteler { get; init; }
  public required IReadOnlyList<EgitimKursSatiriViewModel> OneCikanKurslar { get; init; }
}

public sealed class EgitimKursListeSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<EgitimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<EgitimKursSatiriViewModel> Kurslar { get; init; }
}

public sealed class EgitimKursDetaySayfaViewModel
{
  public required int Id { get; init; }
  public required string KursAdi { get; init; }
  public required string Aciklama { get; init; }
  public required string Egitmen { get; init; }
  public required string Seviye { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Sure { get; init; }
  public required int IlerlemeYuzde { get; init; }
  public required IReadOnlyList<EgitimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<EgitimBolumViewModel> Bolumler { get; init; }
  public required IReadOnlyList<string> Kazanimlar { get; init; }
}

public sealed class EgitimKursIcerikSayfaViewModel
{
  public required int KursId { get; init; }
  public required string KursAdi { get; init; }
  public required string Aciklama { get; init; }
  public required string Egitmen { get; init; }
  public required int IlerlemeYuzde { get; init; }
  public required IReadOnlyList<EgitimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<EgitimDersViewModel> Dersler { get; init; }
}

public sealed class EgitimSertifikaSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<EgitimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<EgitimSertifikaViewModel> Sertifikalar { get; init; }
}

public static class EgitimWorkspaceFactory
{
  private static readonly IReadOnlyList<KursKaynakKaydi> Kurslar =
  [
    new()
    {
      Id = 1,
      KursAdi = "Modern Tarım Pazarlaması",
      Egitmen = "Dr. Ayşe Çelik",
      Seviye = "Orta",
      Durum = "Devam Ediyor",
      DurumTonu = "warning",
      Ozet = "Üretici, kategori yönetimi ve dijital satış ritmini aynı akışta ele alır.",
      SureDakika = 320,
      IlerlemeYuzde = 45,
      SonGuncelleme = "Bugün",
      ModulSayisi = 3,
      Kazanimlar =
      [
        "Kampanya ve kategori açılış planı oluşturma",
        "Ürün görünürlüğü ile talep tahmini arasında ilişki kurma",
        "B2B müşteri segmentlerinde fiyatlama refleksi geliştirme"
      ]
    },
    new()
    {
      Id = 2,
      KursAdi = "Gıda Lojistiği ve Soğuk Zincir",
      Egitmen = "Müh. Mehmet Aslan",
      Seviye = "İleri",
      Durum = "Beklemede",
      DurumTonu = "info",
      Ozet = "Teslimat penceresi, araç kapasitesi ve soğuk zincir operasyonu üzerine yoğunlaşır.",
      SureDakika = 210,
      IlerlemeYuzde = 0,
      SonGuncelleme = "3 gün önce",
      ModulSayisi = 4,
      Kazanimlar =
      [
        "Rota planı ile ürün hassasiyeti eşleştirme",
        "Slot bazlı yükleme disiplini kurma",
        "Lojistik riskleri erken okuma"
      ]
    },
    new()
    {
      Id = 3,
      KursAdi = "Temel E-Ticaret Eğitimi",
      Egitmen = "Kalkan Akademi",
      Seviye = "Başlangıç",
      Durum = "Tamamlandı",
      DurumTonu = "success",
      Ozet = "Sipariş, katalog ve müşteri deneyimini PazarCep iş akışları üzerinden anlatır.",
      SureDakika = 180,
      IlerlemeYuzde = 100,
      SonGuncelleme = "10 gün önce",
      ModulSayisi = 3,
      Kazanimlar =
      [
        "Ürün listeleme ve teklif akışı temelleri",
        "Sipariş yaşam döngüsü okuması",
        "Müşteri modülü ile operasyon bağı kurma"
      ]
    },
    new()
    {
      Id = 4,
      KursAdi = "CRM ile Hizmet Kalitesi Yönetimi",
      Egitmen = "Burcu Tan",
      Seviye = "Orta",
      Durum = "Devam Ediyor",
      DurumTonu = "success",
      Ozet = "Destek kuyruğu, temsilci notları ve hesap sağlığı sinyallerini ürünleştirir.",
      SureDakika = 260,
      IlerlemeYuzde = 72,
      SonGuncelleme = "Dün",
      ModulSayisi = 5,
      Kazanimlar =
      [
        "Riskli hesapları erken tanımlama",
        "Destek taleplerini müşteri bağlamına bağlama",
        "Temsilci notlarını aksiyona dönüştürme"
      ]
    }
  ];

  public static EgitimOzetSayfaViewModel CreateOverview()
  {
    return new()
    {
      Baslik = "Eğitim ve gelişim merkezi",
      Aciklama = "Operasyon ekiplerinin e-ticaret, lojistik ve CRM becerilerini aynı öğrenme yüzeyinde takip edin.",
      OzetKartlar =
      [
        new() { Baslik = "Toplam kurs", Deger = Kurslar.Count.ToString(), Aciklama = "Aktif eğitim kataloğu", Ikon = "bx-book-open" },
        new() { Baslik = "Devam edilen", Deger = Kurslar.Count(x => x.IlerlemeYuzde > 0 && x.IlerlemeYuzde < 100).ToString(), Aciklama = "Takipte olan öğrenme akışı", Ikon = "bx-play-circle" },
        new() { Baslik = "Tamamlanan", Deger = Kurslar.Count(x => x.IlerlemeYuzde >= 100).ToString(), Aciklama = "Bitirilen eğitim modülü", Ikon = "bx-check-circle" },
        new() { Baslik = "Sertifika", Deger = "2", Aciklama = "Tamamlanan doğrulanmış çıktı", Ikon = "bx-award" }
      ],
      Uyarilar =
      [
        new() { Baslik = "Soğuk zincir kursu beklemede", Ozet = "Lojistik tarafında yüksek etkili kurs henüz başlatılmadı; yeni rota akışları için önceliklendirilmeli.", Ton = "warning", EylemMetni = "Kursa git", EylemLinki = "/Egitim/Kurs/Detay/2" },
        new() { Baslik = "CRM eğitimi yüksek tamamlama oranında", Ozet = "Müşteri yönetimi tarafında eğitim ilerlemesi operasyon kalitesi ile hizalı görünüyor.", Ton = "info", EylemMetni = "İçeriği aç", EylemLinki = "/Egitim/Kurs/Icerik/4" }
      ],
      Aktiviteler =
      [
        new() { Baslik = "Bölüm tamamlandı", Aciklama = "CRM ile Hizmet Kalitesi Yönetimi kursunda destek kuyruğu modülü bitirildi.", Zaman = "Bugün 10:05", Ikon = "bx-check-double" },
        new() { Baslik = "Yeni ders atandı", Aciklama = "Soğuk zincir kursu lojistik ekibi için önerilen öğrenme listesine eklendi.", Zaman = "Dün 16:20", Ikon = "bx-list-plus" },
        new() { Baslik = "Sertifika doğrulandı", Aciklama = "Temel E-Ticaret Eğitimi sertifikası operasyon özgeçmişine işlendi.", Zaman = "18 Nisan 2026", Ikon = "bx-award" }
      ],
      OneCikanKurslar = Kurslar
        .OrderByDescending(x => x.IlerlemeYuzde)
        .Take(3)
        .Select(MapCourse)
        .ToList()
    };
  }

  public static EgitimKursListeSayfaViewModel CreateCourseListPage()
  {
    return new()
    {
      Baslik = "Kurs kataloğu ve öğrenme kuyruğu",
      Aciklama = "Eğitimleri seviye, ilerleme ve operasyon etkisine göre takip edin. Masaüstünde yoğun tablo, mobilde karar odaklı kart yapısı sunulur.",
      OzetKartlar =
      [
        new() { Baslik = "Aktif rota", Deger = $"{Kurslar.Sum(x => x.SureDakika)} dk", Aciklama = "Toplam öğrenme kapasitesi", Ikon = "bx-time-five" },
        new() { Baslik = "Ortalama ilerleme", Deger = $"{Kurslar.Average(x => x.IlerlemeYuzde):N0}%", Aciklama = "Tüm kursların mevcut seviyesi", Ikon = "bx-line-chart" },
        new() { Baslik = "İleri seviye", Deger = Kurslar.Count(x => x.Seviye == "İleri").ToString(), Aciklama = "Uzmanlık odaklı modüller", Ikon = "bx-trending-up" },
        new() { Baslik = "Tamamlanma alarmı", Deger = Kurslar.Count(x => x.IlerlemeYuzde == 0).ToString(), Aciklama = "Henüz başlamayan kurs", Ikon = "bx-alarm-exclamation" }
      ],
      Kurslar = Kurslar.Select(MapCourse).ToList()
    };
  }

  public static EgitimKursDetaySayfaViewModel? CreateCourseDetailPage(int id)
  {
    var kurs = ResolveCourse(id);
    if (kurs is null)
    {
      return null;
    }

    return new()
    {
      Id = kurs.Id,
      KursAdi = kurs.KursAdi,
      Aciklama = kurs.Ozet,
      Egitmen = kurs.Egitmen,
      Seviye = kurs.Seviye,
      Durum = kurs.Durum,
      DurumTonu = kurs.DurumTonu,
      Sure = $"{kurs.SureDakika} dk",
      IlerlemeYuzde = kurs.IlerlemeYuzde,
      OzetKartlar =
      [
        new() { Baslik = "İlerleme", Deger = $"{kurs.IlerlemeYuzde}%", Aciklama = "Tamamlanan öğrenme oranı", Ikon = "bx-pie-chart-alt-2" },
        new() { Baslik = "Modül", Deger = kurs.ModulSayisi.ToString(), Aciklama = "Bölüm bazlı yapı", Ikon = "bx-layer" },
        new() { Baslik = "Süre", Deger = $"{kurs.SureDakika} dk", Aciklama = "Toplam eğitim süresi", Ikon = "bx-time" },
        new() { Baslik = "Durum", Deger = kurs.Durum, Aciklama = "Öğrenme akışı durumu", Ikon = "bx-flag" }
      ],
      Bolumler = BuildSections(kurs),
      Kazanimlar = kurs.Kazanimlar
    };
  }

  public static EgitimKursIcerikSayfaViewModel? CreateCourseContentPage(int id)
  {
    var kurs = ResolveCourse(id);
    if (kurs is null)
    {
      return null;
    }

    var dersler = BuildLessons(kurs);
    return new()
    {
      KursId = kurs.Id,
      KursAdi = kurs.KursAdi,
      Aciklama = kurs.Ozet,
      Egitmen = kurs.Egitmen,
      IlerlemeYuzde = kurs.IlerlemeYuzde,
      OzetKartlar =
      [
        new() { Baslik = "Toplam ders", Deger = dersler.Count.ToString(), Aciklama = "İçerikte listelenen öğrenme adımı", Ikon = "bx-list-ul" },
        new() { Baslik = "Tamamlanan", Deger = dersler.Count(x => x.Tamamlandi).ToString(), Aciklama = "Bitirilen ders adedi", Ikon = "bx-check-double" },
        new() { Baslik = "Kalan süre", Deger = $"{dersler.Where(x => !x.Tamamlandi).Count() * 18} dk", Aciklama = "Ortalama kalan izleme süresi", Ikon = "bx-hourglass" },
        new() { Baslik = "İlerleme", Deger = $"{kurs.IlerlemeYuzde}%", Aciklama = "Kurs genel görünümü", Ikon = "bx-bar-chart-alt-2" }
      ],
      Dersler = dersler
    };
  }

  public static EgitimSertifikaSayfaViewModel CreateCertificatesPage()
  {
    var sertifikalar = new List<EgitimSertifikaViewModel>
    {
      new() { Baslik = "Temel E-Ticaret Sertifikası", Kurum = "Kalkan Akademi", Tarih = "12 Nisan 2026", Kod = "PZC-EDU-1043", Kapsam = "Sipariş, katalog ve müşteri temel akışları" },
      new() { Baslik = "CRM Hizmet Kalitesi Sertifikası", Kurum = "PazarCep Eğitim", Tarih = "03 Nisan 2026", Kod = "PZC-CRM-2071", Kapsam = "Müşteri sağlığı, destek ve temsilci notları" }
    };

    return new()
    {
      Baslik = "Sertifikalar ve çıktı geçmişi",
      Aciklama = "Tamamlanan eğitimlerin doğrulanmış çıktısını ve kapsamını tek ekranda yönetin.",
      OzetKartlar =
      [
        new() { Baslik = "Toplam sertifika", Deger = sertifikalar.Count.ToString(), Aciklama = "Doğrulanmış belge sayısı", Ikon = "bx-award" },
        new() { Baslik = "Son kazanım", Deger = "12 Nisan", Aciklama = "En son belge üretim tarihi", Ikon = "bx-calendar-star" },
        new() { Baslik = "Aktif iz", Deger = "2 profil", Aciklama = "Operasyon özgeçmişine işlenen eğitim", Ikon = "bx-briefcase-alt-2" },
        new() { Baslik = "PDF hazır", Deger = "Talep üzerine", Aciklama = "Belge akışı kontrollü üretilir", Ikon = "bx-file" }
      ],
      Sertifikalar = sertifikalar
    };
  }

  private static EgitimKursSatiriViewModel MapCourse(KursKaynakKaydi kurs)
  {
    return new()
    {
      Id = kurs.Id,
      KursAdi = kurs.KursAdi,
      Egitmen = kurs.Egitmen,
      Seviye = kurs.Seviye,
      Durum = kurs.Durum,
      DurumTonu = kurs.DurumTonu,
      Ozet = kurs.Ozet,
      Sure = $"{kurs.SureDakika} dk",
      SonGuncelleme = kurs.SonGuncelleme,
      Moduller = $"{kurs.ModulSayisi} modül",
      IlerlemeMetni = kurs.IlerlemeYuzde >= 100 ? "Tamamlandı" : kurs.IlerlemeYuzde == 0 ? "Henüz başlanmadı" : "Aktif öğrenme akışı",
      IlerlemeYuzde = kurs.IlerlemeYuzde
    };
  }

  private static IReadOnlyList<EgitimBolumViewModel> BuildSections(KursKaynakKaydi kurs)
  {
    return
    [
      new() { Baslik = "Giriş ve çerçeve", Ozet = "Temel kavramlar ve PazarCep bağlamı.", DersSayisi = "4 ders", Tamamlanma = kurs.IlerlemeYuzde >= 20 ? "Tamamlandı" : "Sırada", Ton = kurs.IlerlemeYuzde >= 20 ? "success" : "info" },
      new() { Baslik = "Uygulamalı senaryolar", Ozet = "Gerçek operasyon örnekleri ve kontrol listeleri.", DersSayisi = "5 ders", Tamamlanma = kurs.IlerlemeYuzde >= 60 ? "Aktif" : "Planlı", Ton = kurs.IlerlemeYuzde >= 60 ? "warning" : "info" },
      new() { Baslik = "Değerlendirme ve çıktı", Ozet = "Quiz, kontrol noktaları ve sertifika hazırlığı.", DersSayisi = $"{Math.Max(2, kurs.ModulSayisi)} ders", Tamamlanma = kurs.IlerlemeYuzde >= 100 ? "Hazır" : "Bekliyor", Ton = kurs.IlerlemeYuzde >= 100 ? "success" : "secondary" }
    ];
  }

  private static IReadOnlyList<EgitimDersViewModel> BuildLessons(KursKaynakKaydi kurs)
  {
    return
    [
      new() { Id = 1, Baslik = "Kursa giriş ve hedefler", Sure = "8 dk", Durum = kurs.IlerlemeYuzde >= 10 ? "Tamamlandı" : "Bekliyor", DurumTonu = kurs.IlerlemeYuzde >= 10 ? "success" : "info", Ozet = "Öğrenme hedefleri ve iş bağlamı tanıtılır.", Tamamlandi = kurs.IlerlemeYuzde >= 10 },
      new() { Id = 2, Baslik = "Temel kavramlar", Sure = "14 dk", Durum = kurs.IlerlemeYuzde >= 25 ? "Tamamlandı" : "Sırada", DurumTonu = kurs.IlerlemeYuzde >= 25 ? "success" : "warning", Ozet = "Kursun temel terimleri ve karar çerçevesi.", Tamamlandi = kurs.IlerlemeYuzde >= 25 },
      new() { Id = 3, Baslik = "Operasyon senaryosu 1", Sure = "22 dk", Durum = kurs.IlerlemeYuzde >= 45 ? "Tamamlandı" : "Aktif", DurumTonu = kurs.IlerlemeYuzde >= 45 ? "success" : "warning", Ozet = "Gerçek iş akışı üzerinden uygulama örneği.", Tamamlandi = kurs.IlerlemeYuzde >= 45 },
      new() { Id = 4, Baslik = "Operasyon senaryosu 2", Sure = "26 dk", Durum = kurs.IlerlemeYuzde >= 70 ? "Tamamlandı" : "Bekliyor", DurumTonu = kurs.IlerlemeYuzde >= 70 ? "success" : "info", Ozet = "İkinci senaryo ve kontrol listesi.", Tamamlandi = kurs.IlerlemeYuzde >= 70 },
      new() { Id = 5, Baslik = "Mini quiz ve kapanış", Sure = "10 dk", Durum = kurs.IlerlemeYuzde >= 100 ? "Tamamlandı" : "Bekliyor", DurumTonu = kurs.IlerlemeYuzde >= 100 ? "success" : "secondary", Ozet = "Öğrenme doğrulaması ve sonraki adım.", Tamamlandi = kurs.IlerlemeYuzde >= 100 }
    ];
  }

  private static KursKaynakKaydi? ResolveCourse(int id)
  {
    return Kurslar.FirstOrDefault(x => x.Id == id);
  }

  private sealed class KursKaynakKaydi
  {
    public required int Id { get; init; }
    public required string KursAdi { get; init; }
    public required string Egitmen { get; init; }
    public required string Seviye { get; init; }
    public required string Durum { get; init; }
    public required string DurumTonu { get; init; }
    public required string Ozet { get; init; }
    public required int SureDakika { get; init; }
    public required int IlerlemeYuzde { get; init; }
    public required string SonGuncelleme { get; init; }
    public required int ModulSayisi { get; init; }
    public required IReadOnlyList<string> Kazanimlar { get; init; }
  }
}
