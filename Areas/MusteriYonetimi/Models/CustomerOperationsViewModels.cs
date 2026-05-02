using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.MusteriYonetimi.Models;

public sealed class MusteriYonetimOzetKartViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ikon { get; init; }
}

public sealed class MusteriYonetimAkisViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string EylemMetni { get; init; }
  public required string EylemLinki { get; init; }
}

public sealed class MusteriYonetimSegmentViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Deger { get; init; }
  public required string Ikon { get; init; }
}

public sealed class MusteriYonetimBaglantiViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Ikon { get; init; }
  public required string Link { get; init; }
}

public sealed class MusteriYonetimOzetSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<MusteriYonetimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<MusteriYonetimAkisViewModel> OncelikliAkislar { get; init; }
  public required IReadOnlyList<MusteriYonetimSegmentViewModel> PortfoySegmentleri { get; init; }
  public required IReadOnlyList<MusteriYonetimBaglantiViewModel> HizliBaglantilar { get; init; }
}

public sealed class MusteriYonetimMusteriSatiriViewModel
{
  public required int Id { get; init; }
  public required string MusteriKodu { get; init; }
  public required string AdSoyadUnvan { get; init; }
  public required string Sirket { get; init; }
  public required string Segment { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Sehir { get; init; }
  public required string Temsilci { get; init; }
  public required string Telefon { get; init; }
  public required string Eposta { get; init; }
  public required string SonEtkilesim { get; init; }
  public required string AcikSiparis { get; init; }
  public required string SaglikSkoru { get; init; }
  public required string YasamBoyuDeger { get; init; }
}

public sealed class MusteriListeSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<MusteriYonetimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<MusteriYonetimMusteriSatiriViewModel> Musteriler { get; init; }
}

public sealed class MusteriKayitFormViewModel
{
  [Required, StringLength(120)]
  [Display(Name = "Ad soyad / unvan")]
  public string AdSoyadUnvan { get; set; } = string.Empty;

  [Required, StringLength(120)]
  [Display(Name = "Sirket")]
  public string Sirket { get; set; } = string.Empty;

  [Required, StringLength(30)]
  [Display(Name = "Telefon")]
  public string Telefon { get; set; } = string.Empty;

  [EmailAddress, StringLength(120)]
  [Display(Name = "E-posta")]
  public string? Eposta { get; set; }

  [StringLength(120)]
  [Display(Name = "Segment")]
  public string Segment { get; set; } = "Kurumsal";

  [StringLength(120)]
  [Display(Name = "Temsilci")]
  public string Temsilci { get; set; } = "Deniz Sahin";

  [StringLength(250)]
  [Display(Name = "Adres")]
  public string? Adres { get; set; }

  [Display(Name = "Aktif hesap")]
  public bool AktifMi { get; set; } = true;
}

public sealed class MusteriYonetimSiparisSatiriViewModel
{
  public required int SiparisId { get; init; }
  public required int MusteriId { get; init; }
  public required string SiparisNo { get; init; }
  public required string Musteri { get; init; }
  public required string Kanal { get; init; }
  public required string Tarih { get; init; }
  public required string Tutar { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string SevkPenceresi { get; init; }
  public required string OperasyonNotu { get; init; }
}

public sealed class MusteriYonetimSiparisSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string VurguBasligi { get; init; }
  public required string VurguMetni { get; init; }
  public required string VurguTonu { get; init; }
  public required IReadOnlyList<MusteriYonetimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<MusteriYonetimSiparisSatiriViewModel> Siparisler { get; init; }
}

public sealed class MusteriYonetimDestekSatiriViewModel
{
  public required int MusteriId { get; init; }
  public required string TalepNo { get; init; }
  public required string Konu { get; init; }
  public required string Musteri { get; init; }
  public required string Kanal { get; init; }
  public required string Oncelik { get; init; }
  public required string OncelikTonu { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Tarih { get; init; }
  public required string Ozet { get; init; }
}

public sealed class MusteriYonetimDestekSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string KuyrukEtiketi { get; init; }
  public required IReadOnlyList<MusteriYonetimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<MusteriYonetimDestekSatiriViewModel> Talepler { get; init; }
}

public sealed class MusteriYonetimNotSatiriViewModel
{
  public required int MusteriId { get; init; }
  public required string Musteri { get; init; }
  public required string Baslik { get; init; }
  public required string Icerik { get; init; }
  public required string Kanal { get; init; }
  public required string Tarih { get; init; }
  public required string Temsilci { get; init; }
}

public sealed class MusteriYonetimPlaybookAdimiViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
}

public sealed class MusteriYonetimNotSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<MusteriYonetimOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<MusteriYonetimNotSatiriViewModel> Notlar { get; init; }
  public required IReadOnlyList<MusteriYonetimPlaybookAdimiViewModel> Playbook { get; init; }
}

public static class MusteriYonetimiWorkspaceFactory
{
  private static readonly IReadOnlyList<MusteriKaynakKaydi> Musteriler =
  [
    new()
    {
      Id = 1024,
      MusteriKodu = "PZC-1024",
      AdSoyadUnvan = "Ayse Kaya",
      Sirket = "Kaya Restoran Grubu",
      Segment = "Kurumsal",
      Durum = "Aktif",
      DurumTonu = "success",
      Sehir = "Istanbul / Kadikoy",
      Temsilci = "Deniz Sahin",
      Telefon = "+90 532 441 18 27",
      Eposta = "ayse.kaya@kayarestoran.com",
      SonEtkilesim = "Bugun 10:45",
      AcikSiparis = 4,
      SaglikSkoru = 92,
      YasamBoyuDeger = 148240m
    },
    new()
    {
      Id = 1078,
      MusteriKodu = "PZC-1078",
      AdSoyadUnvan = "Murat Demir",
      Sirket = "Demir Organik",
      Segment = "Sadik Perakende",
      Durum = "Buyuyor",
      DurumTonu = "info",
      Sehir = "Ankara / Cankaya",
      Temsilci = "Ece Yildirim",
      Telefon = "+90 541 772 66 19",
      Eposta = "murat@demirorganik.com",
      SonEtkilesim = "Dun 16:20",
      AcikSiparis = 3,
      SaglikSkoru = 86,
      YasamBoyuDeger = 62800m
    },
    new()
    {
      Id = 1091,
      MusteriKodu = "PZC-1091",
      AdSoyadUnvan = "Selin Aksoy",
      Sirket = "Aksoy Catering",
      Segment = "Kurumsal",
      Durum = "Takip Gerekli",
      DurumTonu = "warning",
      Sehir = "Izmir / Bornova",
      Temsilci = "Deniz Sahin",
      Telefon = "+90 533 915 42 80",
      Eposta = "selin.aksoy@aksoycatering.com",
      SonEtkilesim = "2 gun once",
      AcikSiparis = 2,
      SaglikSkoru = 71,
      YasamBoyuDeger = 41900m
    },
    new()
    {
      Id = 1117,
      MusteriKodu = "PZC-1117",
      AdSoyadUnvan = "Emre Isik",
      Sirket = "Isik Marketler Zinciri",
      Segment = "Bolgesel Zincir",
      Durum = "Aktif",
      DurumTonu = "success",
      Sehir = "Bursa / Nilufer",
      Temsilci = "Burcu Tan",
      Telefon = "+90 545 612 92 73",
      Eposta = "emre.isik@isikmarket.com",
      SonEtkilesim = "Bugun 08:12",
      AcikSiparis = 5,
      SaglikSkoru = 89,
      YasamBoyuDeger = 91300m
    },
    new()
    {
      Id = 1150,
      MusteriKodu = "PZC-1150",
      AdSoyadUnvan = "Zeynep Ozturk",
      Sirket = "Ozturk Gurme",
      Segment = "Yeni Kazanim",
      Durum = "Onboarding",
      DurumTonu = "info",
      Sehir = "Antalya / Muratpasa",
      Temsilci = "Ece Yildirim",
      Telefon = "+90 537 220 18 44",
      Eposta = "zeynep@ozturkgurme.com",
      SonEtkilesim = "3 saat once",
      AcikSiparis = 1,
      SaglikSkoru = 78,
      YasamBoyuDeger = 18750m
    },
    new()
    {
      Id = 1189,
      MusteriKodu = "PZC-1189",
      AdSoyadUnvan = "Kerem Arslan",
      Sirket = "Arslan Taze Urunler",
      Segment = "Riskte",
      Durum = "Kritik",
      DurumTonu = "danger",
      Sehir = "Adana / Seyhan",
      Temsilci = "Burcu Tan",
      Telefon = "+90 535 811 09 90",
      Eposta = "kerem.arslan@arslantaze.com",
      SonEtkilesim = "5 gun once",
      AcikSiparis = 1,
      SaglikSkoru = 58,
      YasamBoyuDeger = 27480m
    }
  ];

  private static readonly IReadOnlyList<MusteriYonetimSiparisSatiriViewModel> Siparisler =
  [
    new() { SiparisId = 50124, MusteriId = 1024, SiparisNo = "SC-50124", Musteri = "Ayse Kaya", Kanal = "Mobil", Tarih = "2026.04.22", Tutar = "₺12.450", Durum = "Hazirlaniyor", DurumTonu = "warning", SevkPenceresi = "07:00 - 09:00", OperasyonNotu = "Sabah slotu icin depo cikisi onaylandi." },
    new() { SiparisId = 50111, MusteriId = 1078, SiparisNo = "SC-50111", Musteri = "Murat Demir", Kanal = "Web", Tarih = "2026.04.22", Tutar = "₺8.940", Durum = "Sevke Hazir", DurumTonu = "success", SevkPenceresi = "10:00 - 12:00", OperasyonNotu = "Rota ve arac atamasi tamamlandi." },
    new() { SiparisId = 50098, MusteriId = 1117, SiparisNo = "SC-50098", Musteri = "Emre Isik", Kanal = "Temsilci", Tarih = "2026.04.22", Tutar = "₺19.260", Durum = "Yeni Siparis", DurumTonu = "info", SevkPenceresi = "13:00 - 15:00", OperasyonNotu = "Kurumsal depo kabul listesi bekleniyor." },
    new() { SiparisId = 50087, MusteriId = 1091, SiparisNo = "SC-50087", Musteri = "Selin Aksoy", Kanal = "Mobil", Tarih = "2026.04.21", Tutar = "₺6.380", Durum = "Beklemede", DurumTonu = "danger", SevkPenceresi = "16:00 - 18:00", OperasyonNotu = "Alternatif urun onayi bekleniyor." },
    new() { SiparisId = 50076, MusteriId = 1150, SiparisNo = "SC-50076", Musteri = "Zeynep Ozturk", Kanal = "Temsilci", Tarih = "2026.04.21", Tutar = "₺4.210", Durum = "Onboarding Kontrolu", DurumTonu = "warning", SevkPenceresi = "11:00 - 13:00", OperasyonNotu = "Ilk sevkiyat icin fatura profili teyidi istendi." }
  ];

  private static readonly IReadOnlyList<MusteriYonetimDestekSatiriViewModel> Talepler =
  [
    new() { MusteriId = 1189, TalepNo = "SKY-0001", Konu = "Geciken teslimat", Musteri = "Kerem Arslan", Kanal = "Telefon", Oncelik = "Yuksek", OncelikTonu = "danger", Durum = "Acik", DurumTonu = "danger", Tarih = "2026.04.20", Ozet = "Ucuncu teslimat penceresinde gecikme yasandi, telafi beklentisi var." },
    new() { MusteriId = 1091, TalepNo = "SKY-0002", Konu = "Eksik urun", Musteri = "Selin Aksoy", Kanal = "Web formu", Oncelik = "Normal", OncelikTonu = "warning", Durum = "Inceleniyor", DurumTonu = "warning", Tarih = "2026.04.21", Ozet = "Iki kalemde adet farki bildirildi, depo ve siparis kaydi eslestiriliyor." },
    new() { MusteriId = 1024, TalepNo = "DST-0010", Konu = "Bildirim tercihleri", Musteri = "Ayse Kaya", Kanal = "Temsilci", Oncelik = "Normal", OncelikTonu = "info", Durum = "Cozuldu", DurumTonu = "success", Tarih = "2026.04.18", Ozet = "Fatura ve operasyon bildirimleri ayri adreslere yonlendirildi." },
    new() { MusteriId = 1117, TalepNo = "DST-0011", Konu = "Panelde hata", Musteri = "Emre Isik", Kanal = "Uygulama", Oncelik = "Yuksek", OncelikTonu = "danger", Durum = "Acik", DurumTonu = "danger", Tarih = "2026.04.21", Ozet = "Toplu siparis ekraninda filtreleme geri bildirimi alindi." }
  ];

  private static readonly IReadOnlyList<MusteriYonetimNotSatiriViewModel> Notlar =
  [
    new() { MusteriId = 1024, Musteri = "Ayse Kaya", Baslik = "SLA teyidi", Icerik = "Sabah ilk teslimat kuralinin devam etmesi istendi. Kritik siparislerde temsilci dogrudan aranacak.", Kanal = "Telefon gorusmesi", Tarih = "Bugun 09:40", Temsilci = "Deniz Sahin" },
    new() { MusteriId = 1117, Musteri = "Emre Isik", Baslik = "Yeni kategori talebi", Icerik = "Atistirmalik ve kuru meyve grubunda yeni kampanya acilisi icin teklif bekliyor.", Kanal = "Saha ziyareti", Tarih = "Dun 15:10", Temsilci = "Burcu Tan" },
    new() { MusteriId = 1150, Musteri = "Zeynep Ozturk", Baslik = "Ilk fatura profili", Icerik = "E-fatura kaydi tamamlandi, muhasebe yetkilisi yarin sisteme eklenecek.", Kanal = "E-posta", Tarih = "2026.04.21", Temsilci = "Ece Yildirim" }
  ];

  public static MusteriYonetimOzetSayfaViewModel CreateOverview()
  {
    return new()
    {
      Baslik = "CRM operasyon merkezi",
      Aciklama = "Musteri portfoyu, siparis kuyrugu, destek etkisi ve temsilci aksiyonlarini tek bir yonetim akisinda toplayin.",
      OzetKartlar =
      [
        new() { Baslik = "Toplam portfoy", Deger = Musteriler.Count.ToString(), Aciklama = "Aktif takipteki ticari hesap", Ikon = "bx-group" },
        new() { Baslik = "Riskte hesap", Deger = Musteriler.Count(x => x.DurumTonu is "warning" or "danger").ToString(), Aciklama = "Yakin takip veya mudahale gerektiren kayit", Ikon = "bx-error-circle" },
        new() { Baslik = "Acik destek", Deger = Talepler.Count(x => x.DurumTonu != "success").ToString(), Aciklama = "Bekleyen destek ve sikayet akisi", Ikon = "bx-support" },
        new() { Baslik = "Acik siparis", Deger = Siparisler.Count.ToString(), Aciklama = "CRM tarafindan izlenen operasyon kaydi", Ikon = "bx-package" }
      ],
      OncelikliAkislar =
      [
        new() { Baslik = "Riskli hesaplar", Ozet = "Kerem Arslan ve Selin Aksoy hesaplarinda teslimat ile odeme tarafinda yakindan takip gerekiyor.", Durum = "Acil", DurumTonu = "danger", EylemMetni = "Musteri listesine git", EylemLinki = "/MusteriYonetimi/Musteriler/Index" },
        new() { Baslik = "Bugun kapanacak siparisler", Ozet = "Sabah ve ogle penceresindeki siparisler CRM tarafinda teyitli temsilci aksiyonu bekliyor.", Durum = "Planli", DurumTonu = "warning", EylemMetni = "Siparisleri ac", EylemLinki = "/MusteriYonetimi/Siparisler/Bekleyen" },
        new() { Baslik = "Destek kalitesi", Ozet = "Panel ve teslimat kaynakli iki acik talep var. Musteri detay alanlari ile cevap hizi artirilmali.", Durum = "Izleniyor", DurumTonu = "info", EylemMetni = "Destek kuyrugu", EylemLinki = "/MusteriYonetimi/Destek/Destek" }
      ],
      PortfoySegmentleri =
      [
        new() { Baslik = "Kurumsal hesaplar", Ozet = "Yuksek ciro ve SLA hassasiyeti olan musteri grubu", Deger = "2 hesap", Ikon = "bx-buildings" },
        new() { Baslik = "Buyuyen perakende", Ozet = "Siparis frekansi artan ve capraz satis potansiyeli tasiyan hesaplar", Deger = "2 hesap", Ikon = "bx-trending-up" },
        new() { Baslik = "Onboarding / yeni kazanım", Ozet = "Hizli adaptasyon ve ilk deneyim kalitesi kritik olan alan", Deger = "1 hesap", Ikon = "bx-user-plus" },
        new() { Baslik = "Risk / churn alarmi", Ozet = "Hizmet kesintisi algisi olan veya destek baskisi artan hesaplar", Deger = "1 hesap", Ikon = "bx-shield-quarter" }
      ],
      HizliBaglantilar =
      [
        new() { Baslik = "Tum musteriler", Ozet = "Portfoyu temsilci ve saglik skoru bazinda tara.", Ikon = "bx-id-card", Link = "/MusteriYonetimi/Musteriler/Index" },
        new() { Baslik = "Musteri calisma alani", Ozet = "ETicaret tarafindaki detayli hesap sayfalarina gec.", Ikon = "bx-grid-alt", Link = "/ETicaret/Musteri/TumMusteriler" },
        new() { Baslik = "Bekleyen siparisler", Ozet = "Oncelikli operasyon kayitlarini filtrelenmis gor.", Ikon = "bx-time-five", Link = "/MusteriYonetimi/Siparisler/Bekleyen" },
        new() { Baslik = "Destek kuyrugu", Ozet = "Acik destek ve sikayetleri temsilci baglamiyla yonet.", Ikon = "bx-message-dots", Link = "/MusteriYonetimi/Destek/Destek" }
      ]
    };
  }

  public static MusteriListeSayfaViewModel CreateCustomerList()
  {
    return new()
    {
      Baslik = "Tum musteriler",
      Aciklama = "CRM portfoyunu segment, temsilci ve saglik gorunumu ile yonetin. Mobilde aksiyon odakli kartlar, masaustunde yuksek yogunluklu tablo sunulur.",
      OzetKartlar =
      [
        new() { Baslik = "Kurumsal hesap", Deger = Musteriler.Count(x => x.Segment.Contains("Kurumsal", StringComparison.OrdinalIgnoreCase)).ToString(), Aciklama = "B2B ve SLA hassas hesaplar", Ikon = "bx-buildings" },
        new() { Baslik = "Ortalama saglik", Deger = $"{Musteriler.Average(x => x.SaglikSkoru):N0}/100", Aciklama = "Musteri deneyimi ve operasyon puani", Ikon = "bx-pulse" },
        new() { Baslik = "Acik siparis", Deger = Musteriler.Sum(x => x.AcikSiparis).ToString(), Aciklama = "Tum portfoyde aktif operasyon adedi", Ikon = "bx-cart" },
        new() { Baslik = "Toplam deger", Deger = $"₺{Musteriler.Sum(x => x.YasamBoyuDeger):N0}", Aciklama = "Portfoy yasam boyu katkisi", Ikon = "bx-wallet" }
      ],
      Musteriler = Musteriler
        .OrderByDescending(x => x.YasamBoyuDeger)
        .Select(x => new MusteriYonetimMusteriSatiriViewModel
        {
          Id = x.Id,
          MusteriKodu = x.MusteriKodu,
          AdSoyadUnvan = x.AdSoyadUnvan,
          Sirket = x.Sirket,
          Segment = x.Segment,
          Durum = x.Durum,
          DurumTonu = x.DurumTonu,
          Sehir = x.Sehir,
          Temsilci = x.Temsilci,
          Telefon = x.Telefon,
          Eposta = x.Eposta,
          SonEtkilesim = x.SonEtkilesim,
          AcikSiparis = x.AcikSiparis.ToString(),
          SaglikSkoru = $"{x.SaglikSkoru}/100",
          YasamBoyuDeger = $"₺{x.YasamBoyuDeger:N0}"
        })
        .ToList()
    };
  }

  public static MusteriKayitFormViewModel CreateCustomerForm()
  {
    return new MusteriKayitFormViewModel
    {
      Segment = "Kurumsal",
      Temsilci = "Deniz Sahin",
      AktifMi = true
    };
  }

  public static MusteriYonetimSiparisSayfaViewModel CreateOrdersPage(bool onlyPending)
  {
    var liste = onlyPending
      ? Siparisler.Where(x => x.DurumTonu is "warning" or "danger").ToList()
      : Siparisler.ToList();

    return new()
    {
      Baslik = onlyPending ? "Bekleyen siparisler" : "Tum siparisler",
      Aciklama = onlyPending
        ? "Temsilci aksiyonu veya musteri onayi bekleyen kayitlari onceliklendirin."
        : "CRM tarafindan izlenen siparisleri durum, pencere ve musteri baglami ile yonetin.",
      VurguBasligi = onlyPending ? "Oncelik alarmi" : "Operasyon senkronu",
      VurguMetni = onlyPending
        ? "Bekleyen kuyrukta urun onayi ve onboarding bagimli kayitlar bulunuyor."
        : "Siparisler ETicaret ve Lojistik akislari ile ayni operasyon dilinde goruntuleniyor.",
      VurguTonu = onlyPending ? "warning" : "info",
      OzetKartlar =
      [
        new() { Baslik = "Kuyruktaki siparis", Deger = liste.Count.ToString(), Aciklama = "Bu gorunumde listelenen kayit", Ikon = "bx-package" },
        new() { Baslik = "Bugun kapanacak", Deger = liste.Count(x => x.Tarih == "2026.04.22").ToString(), Aciklama = "Gun icinde kapanis hedefi olan siparis", Ikon = "bx-calendar-check" },
        new() { Baslik = "Kritik kayit", Deger = liste.Count(x => x.DurumTonu == "danger").ToString(), Aciklama = "Mudahale gerektiren siparis", Ikon = "bx-error" },
        new() { Baslik = "Toplam tutar", Deger = $"₺{liste.Sum(x => decimal.Parse(x.Tutar.Replace("₺", "").Replace(".", string.Empty))):N0}", Aciklama = "Kuyruktaki toplam is hacmi", Ikon = "bx-wallet" }
      ],
      Siparisler = liste
    };
  }

  public static MusteriYonetimDestekSayfaViewModel CreateSupportPage(bool isComplaintQueue)
  {
    var liste = isComplaintQueue
      ? Talepler.Where(x => x.TalepNo.StartsWith("SKY", StringComparison.OrdinalIgnoreCase)).ToList()
      : Talepler.Where(x => x.TalepNo.StartsWith("DST", StringComparison.OrdinalIgnoreCase) || x.DurumTonu != "success").ToList();

    return new()
    {
      Baslik = isComplaintQueue ? "Sikayet talepleri" : "Destek talepleri",
      Aciklama = isComplaintQueue
        ? "Hizmet memnuniyeti etkileyen geri bildirimleri hizli cozum ve temsilci baglami ile yonetin."
        : "Teknik ve operasyonel destek kayitlarini temsilci odakli bir servis panelinde takip edin.",
      KuyrukEtiketi = isComplaintQueue ? "Sikayet Kuyrugu" : "Destek Kuyrugu",
      OzetKartlar =
      [
        new() { Baslik = "Acik talep", Deger = liste.Count(x => x.DurumTonu != "success").ToString(), Aciklama = "Cevap veya kapanis bekleyen kayit", Ikon = "bx-message-error" },
        new() { Baslik = "Yuksek oncelik", Deger = liste.Count(x => x.OncelikTonu == "danger").ToString(), Aciklama = "Birincil mudahale gerektiren talep", Ikon = "bx-alarm-exclamation" },
        new() { Baslik = "Bugun gelen", Deger = liste.Count(x => x.Tarih.Contains("2026.04.22", StringComparison.OrdinalIgnoreCase)).ToString(), Aciklama = "Ayni gun acilan kayit", Ikon = "bx-time-five" },
        new() { Baslik = "Bagli hesap", Deger = liste.Select(x => x.MusteriId).Distinct().Count().ToString(), Aciklama = "Talep ureten farkli musteri", Ikon = "bx-group" }
      ],
      Talepler = liste
    };
  }

  public static MusteriYonetimNotSayfaViewModel CreateNotesPage()
  {
    return new()
    {
      Baslik = "Iletisim ve notlar",
      Aciklama = "Temsilci gorusmeleri, SLA notlari ve sonraki aksiyonlari kayit altinda tutun.",
      OzetKartlar =
      [
        new() { Baslik = "Bugunku temas", Deger = "7", Aciklama = "Telefon, e-posta ve saha gorusmeleri", Ikon = "bx-phone-call" },
        new() { Baslik = "Takip notu", Deger = Notlar.Count.ToString(), Aciklama = "Acik baglam olusturan kayitlar", Ikon = "bx-note" },
        new() { Baslik = "SLA teyidi", Deger = "3 hesap", Aciklama = "Yeniden dogrulanmasi gereken hizmet sozleri", Ikon = "bx-check-circle" },
        new() { Baslik = "Sonraki adim", Deger = "4 gorev", Aciklama = "Yarin icin devreden aksiyonlar", Ikon = "bx-task" }
      ],
      Notlar = Notlar,
      Playbook =
      [
        new() { Baslik = "Temas sonrasi 24 saat icinde not gir", Aciklama = "Temsilci gorusmelerinin ertesi gune kalmadan sisteme alinmasi gerekir.", Durum = "Standart", DurumTonu = "success" },
        new() { Baslik = "Riskli hesapta iki kanaldan teyit al", Aciklama = "Teslimat ve odeme kaynakli sikayetlerde telefon + yazili kayit birlikte tutulur.", Durum = "Zorunlu", DurumTonu = "warning" },
        new() { Baslik = "Onboarding hesaplarda ilk siparis notunu ac", Aciklama = "Ilk deneyim geri bildirimi 48 saat icinde toplanir ve ETicaret calisma alanina yansitilir.", Durum = "Aktif", DurumTonu = "info" }
      ]
    };
  }

  private sealed class MusteriKaynakKaydi
  {
    public required int Id { get; init; }
    public required string MusteriKodu { get; init; }
    public required string AdSoyadUnvan { get; init; }
    public required string Sirket { get; init; }
    public required string Segment { get; init; }
    public required string Durum { get; init; }
    public required string DurumTonu { get; init; }
    public required string Sehir { get; init; }
    public required string Temsilci { get; init; }
    public required string Telefon { get; init; }
    public required string Eposta { get; init; }
    public required string SonEtkilesim { get; init; }
    public required int AcikSiparis { get; init; }
    public required int SaglikSkoru { get; init; }
    public required decimal YasamBoyuDeger { get; init; }
  }
}
