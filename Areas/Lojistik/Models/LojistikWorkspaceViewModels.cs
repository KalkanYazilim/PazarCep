namespace PazarCep.Areas.Lojistik.Models;

public sealed class LojistikOzetKartViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ikon { get; init; }
}

public sealed class LojistikUyariViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Ton { get; init; }
  public required string EylemMetni { get; init; }
  public required string EylemLinki { get; init; }
}

public sealed class LojistikAsamaViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ton { get; init; }
}

public sealed class LojistikSevkiyatSatiriViewModel
{
  public required int AracId { get; init; }
  public required string SevkiyatNo { get; init; }
  public required string Musteri { get; init; }
  public required string Guzergah { get; init; }
  public required string Pencere { get; init; }
  public required string YukTipi { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Arac { get; init; }
  public required string OperasyonNotu { get; init; }
}

public sealed class LojistikAracSatiriViewModel
{
  public required int Id { get; init; }
  public required string Plaka { get; init; }
  public required string AracTipi { get; init; }
  public required string Surucu { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Konum { get; init; }
  public required string SonRota { get; init; }
  public required string SonBakim { get; init; }
  public required string BugunkuKm { get; init; }
  public required string Doluluk { get; init; }
  public required string SonGuncelleme { get; init; }
  public required string OperasyonNotu { get; init; }
}

public sealed class LojistikAracDetayBilgiViewModel
{
  public required int Id { get; init; }
  public required string Plaka { get; init; }
  public required string AracTipi { get; init; }
  public required string Surucu { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Konum { get; init; }
  public required string SonRota { get; init; }
  public required string SonBakim { get; init; }
  public required string SonGuncelleme { get; init; }
  public required string OperasyonOzeti { get; init; }
}

public sealed class LojistikKontrolSatiriViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string EylemMetni { get; init; }
}

public sealed class LojistikZamanAkisiViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Zaman { get; init; }
  public required string Ikon { get; init; }
}

public sealed class LojistikRotaDuragiViewModel
{
  public required string Durak { get; init; }
  public required string ZamanPenceresi { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string Not { get; init; }
}

public sealed class LojistikOzetSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<LojistikOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<LojistikUyariViewModel> Uyarilar { get; init; }
  public required IReadOnlyList<LojistikAsamaViewModel> OperasyonAsamalari { get; init; }
  public required IReadOnlyList<LojistikSevkiyatSatiriViewModel> Sevkiyatlar { get; init; }
  public required IReadOnlyList<LojistikAracSatiriViewModel> FiloOzeti { get; init; }
}

public sealed class LojistikFiloSayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<LojistikOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<LojistikAracSatiriViewModel> Araclar { get; init; }
}

public sealed class LojistikAracDetaySayfaViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required LojistikAracDetayBilgiViewModel Arac { get; init; }
  public required IReadOnlyList<LojistikOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<LojistikKontrolSatiriViewModel> Kontroller { get; init; }
  public required IReadOnlyList<LojistikRotaDuragiViewModel> RotaDuraklari { get; init; }
  public required IReadOnlyList<LojistikZamanAkisiViewModel> ZamanAkisi { get; init; }
}

public static class LojistikWorkspaceFactory
{
  private static readonly IReadOnlyList<LojistikAracSatiriViewModel> Araclar =
  [
    new()
    {
      Id = 1,
      Plaka = "51 ABC 123",
      AracTipi = "Kamyonet",
      Surucu = "Ali Kaya",
      Durum = "Sevkiyatta",
      DurumTonu = "warning",
      Konum = "Nigde -> Ankara",
      SonRota = "Sebze dagitimi / Orta Anadolu",
      SonBakim = "14 Nisan 2026",
      BugunkuKm = "210 km",
      Doluluk = "%82",
      SonGuncelleme = "Bugun 10:12",
      OperasyonNotu = "Sabah soguk zincir cikisini zamaninda tamamladi."
    },
    new()
    {
      Id = 2,
      Plaka = "06 KLM 456",
      AracTipi = "Kamyon",
      Surucu = "Mehmet Aslan",
      Durum = "Musait",
      DurumTonu = "success",
      Konum = "Ankara merkez garaj",
      SonRota = "Transfer / Ankara ici dagitim",
      SonBakim = "18 Nisan 2026",
      BugunkuKm = "35 km",
      Doluluk = "%18",
      SonGuncelleme = "Bugun 09:05",
      OperasyonNotu = "Ogleden sonra iki planli yukleme icin beklemede."
    },
    new()
    {
      Id = 3,
      Plaka = "34 XYZ 789",
      AracTipi = "Tir",
      Surucu = "Hasan Demir",
      Durum = "Serviste",
      DurumTonu = "danger",
      Konum = "Istanbul / Sanayi",
      SonRota = "Depo arasi transfer",
      SonBakim = "22 Nisan 2026",
      BugunkuKm = "0 km",
      Doluluk = "%0",
      SonGuncelleme = "Bugun 08:10",
      OperasyonNotu = "Fren sensoru degisimi sonrasi kalite onayi bekleniyor."
    },
    new()
    {
      Id = 4,
      Plaka = "16 PRS 245",
      AracTipi = "Frigorifik",
      Surucu = "Zehra Kurt",
      Durum = "Planli cikis",
      DurumTonu = "info",
      Konum = "Bursa soguk depo",
      SonRota = "Bursa -> Balikesir",
      SonBakim = "11 Nisan 2026",
      BugunkuKm = "78 km",
      Doluluk = "%64",
      SonGuncelleme = "Bugun 11:20",
      OperasyonNotu = "Saat 13:00 slotu icin yukleme listesi hazir."
    }
  ];

  private static readonly IReadOnlyList<LojistikSevkiyatSatiriViewModel> Sevkiyatlar =
  [
    new()
    {
      AracId = 1,
      SevkiyatNo = "SVK-2026-041",
      Musteri = "Kaya Restoran Grubu",
      Guzergah = "Nigde -> Ankara",
      Pencere = "07:00 - 09:00",
      YukTipi = "Soguk zincir / Sebze",
      Durum = "Yolda",
      DurumTonu = "warning",
      Arac = "51 ABC 123",
      OperasyonNotu = "Ankara girisinde 18 dakikalik yogunluk gorunuyor."
    },
    new()
    {
      AracId = 2,
      SevkiyatNo = "SVK-2026-042",
      Musteri = "Demir Organik",
      Guzergah = "Ankara -> Cankaya",
      Pencere = "10:00 - 12:00",
      YukTipi = "Karma koli",
      Durum = "Yukleme bekliyor",
      DurumTonu = "info",
      Arac = "06 KLM 456",
      OperasyonNotu = "Depo kabul listesi dogrulaniyor."
    },
    new()
    {
      AracId = 4,
      SevkiyatNo = "SVK-2026-043",
      Musteri = "Isik Marketler Zinciri",
      Guzergah = "Bursa -> Balikesir",
      Pencere = "13:00 - 15:00",
      YukTipi = "Toplu market siparisi",
      Durum = "Planlandi",
      DurumTonu = "success",
      Arac = "16 PRS 245",
      OperasyonNotu = "Rota ve kabul randevusu senkron durumda."
    }
  ];

  public static LojistikOzetSayfaViewModel CreateOverview()
  {
    return new()
    {
      Baslik = "Lojistik operasyon merkezi",
      Aciklama = "Arac doluluklari, sevkiyat riski ve rota senkronunu tek bakista yonetin. Masaustunde yogun operasyon gorunumu, mobilde ise karar vermeyi kolaylastiran kart yapisi sunulur.",
      OzetKartlar =
      [
        new() { Baslik = "Aktif arac", Deger = "12", Aciklama = "Bugun operasyon planinda gorunen araclar", Ikon = "bx-car" },
        new() { Baslik = "Yoldaki sevkiyat", Deger = "4", Aciklama = "Canli rota izlemeye acik kayit", Ikon = "bx-map-alt" },
        new() { Baslik = "Servis bekleyen", Deger = "2", Aciklama = "Bakim ve teknik onay asamasindaki arac", Ikon = "bx-wrench" },
        new() { Baslik = "Slot uyumu", Deger = "%94", Aciklama = "Randevu ve sevkiyat plani tutarliligi", Ikon = "bx-check-shield" }
      ],
      Uyarilar =
      [
        new() { Baslik = "Istanbul servisteki arac aksam slotlarini etkileyebilir", Ozet = "34 XYZ 789 kalite onayi almadan yarin sabah cikisa verilemez. Alternatif arac planlamasi hazir tutulmali.", Ton = "danger", EylemMetni = "Arac detayini ac", EylemLinki = "/Lojistik/Filo/AracDetay/3" },
        new() { Baslik = "Ankara dagitim penceresi doluyor", Ozet = "Sabah dagitimlarinda ayni pencereye yigilan iki siparis icin ek yukleme disiplini gerekiyor.", Ton = "warning", EylemMetni = "Filo planini gor", EylemLinki = "/Lojistik/Filo/Index" },
        new() { Baslik = "Randevu sistemi ile rota uyumu guclu", Ozet = "Bursa cikisli market sevkiyatlari artik ETicaret randevu akisi ile esitlenmis durumda.", Ton = "info", EylemMetni = "Randevu alanina git", EylemLinki = "/ETicaret/Randevu/Index" }
      ],
      OperasyonAsamalari =
      [
        new() { Baslik = "Yukleme hazirligi", Deger = "3 kayit", Aciklama = "Depo etiket ve yukleme listesi asamasinda.", Ton = "info" },
        new() { Baslik = "Yolda", Deger = "4 arac", Aciklama = "Canli konum ve pencere takibi aktif.", Ton = "warning" },
        new() { Baslik = "Teslim onayi", Deger = "2 kayit", Aciklama = "Musteri kabul onayi bekleyen sevkiyatlar.", Ton = "success" },
        new() { Baslik = "Risk alarmi", Deger = "1 kritik", Aciklama = "Teknik onay veya rota gecikmesi olan isler.", Ton = "danger" }
      ],
      Sevkiyatlar = Sevkiyatlar,
      FiloOzeti = Araclar
    };
  }

  public static LojistikFiloSayfaViewModel CreateFleetPage()
  {
    return new()
    {
      Baslik = "Filo ve saha kullanimi",
      Aciklama = "Arac durumunu, surucu sahipligini ve bakim baglamini tek listede yonetin. Mobil duzende her arac karar odakli bir kart olarak sunulur.",
      OzetKartlar =
      [
        new() { Baslik = "Musait arac", Deger = Araclar.Count(x => x.DurumTonu == "success").ToString(), Aciklama = "Yeni sevkiyat atamasina uygun", Ikon = "bx-check-circle" },
        new() { Baslik = "Planli cikis", Deger = Araclar.Count(x => x.DurumTonu == "info").ToString(), Aciklama = "Gun icinde rota alacak arac", Ikon = "bx-log-in-circle" },
        new() { Baslik = "Bakim / servis", Deger = Araclar.Count(x => x.DurumTonu == "danger").ToString(), Aciklama = "Teknik ekip kontrolunde", Ikon = "bx-cog" },
        new() { Baslik = "Ortalama doluluk", Deger = "%41", Aciklama = "Gunluk operasyon verimine gore", Ikon = "bx-bar-chart-alt-2" }
      ],
      Araclar = Araclar
    };
  }

  public static LojistikAracDetaySayfaViewModel? CreateVehicleDetailPage(int id)
  {
    var arac = Araclar.FirstOrDefault(x => x.Id == id);

    if (arac is null)
    {
      return null;
    }

    return new()
    {
      Baslik = $"{arac.Plaka} saha gorunumu",
      Aciklama = "Arac sagligi, aktif rota ve operasyon denetim adimlarini tek bir detay ekraninda inceleyin.",
      Arac = new LojistikAracDetayBilgiViewModel
      {
        Id = arac.Id,
        Plaka = arac.Plaka,
        AracTipi = arac.AracTipi,
        Surucu = arac.Surucu,
        Durum = arac.Durum,
        DurumTonu = arac.DurumTonu,
        Konum = arac.Konum,
        SonRota = arac.SonRota,
        SonBakim = arac.SonBakim,
        SonGuncelleme = arac.SonGuncelleme,
        OperasyonOzeti = arac.OperasyonNotu
      },
      OzetKartlar =
      [
        new() { Baslik = "Bugunku km", Deger = arac.BugunkuKm, Aciklama = "Canli rota ilerlemesi", Ikon = "bx-route" },
        new() { Baslik = "Doluluk", Deger = arac.Doluluk, Aciklama = "Yuk ve kapasite dengesi", Ikon = "bx-package" },
        new() { Baslik = "Son bakim", Deger = arac.SonBakim, Aciklama = "Planli teknik kontrol", Ikon = "bx-wrench" },
        new() { Baslik = "Surucu sahibi", Deger = arac.Surucu, Aciklama = "Birincil saha sorumlusu", Ikon = "bx-user-pin" }
      ],
      Kontroller =
      [
        new() { Baslik = "Yakit ve enerji kontrolu", Aciklama = "Sevkiyat bitimine kadar yeterli doluluk teyit edildi.", Durum = "Uygun", DurumTonu = "success", EylemMetni = "Kontrol fisini gor" },
        new() { Baslik = "Belgeler ve izinler", Aciklama = "Sigorta, ruhsat ve rota izinleri guncel tutuluyor.", Durum = "Takipte", DurumTonu = "info", EylemMetni = "Belgelere git" },
        new() { Baslik = "Teknik kalite", Aciklama = id == 3 ? "Servis sonrasi cikis onayi heniz tamamlanmadi." : "Sahaya cikisi engelleyen bir teknik risk gorulmuyor.", Durum = id == 3 ? "Kritik" : "Guclu", DurumTonu = id == 3 ? "danger" : "success", EylemMetni = "Atolye notlarini incele" }
      ],
      RotaDuraklari =
      [
        new() { Durak = "Merkez depo cikisi", ZamanPenceresi = "06:45 - 07:00", Durum = "Tamamlandi", DurumTonu = "success", Not = "Yukleme listesi ile tam uyumlu." },
        new() { Durak = "Musteri kabul noktasi", ZamanPenceresi = "08:15 - 08:45", Durum = id == 3 ? "Ertelendi" : "Planlandi", DurumTonu = id == 3 ? "danger" : "info", Not = id == 3 ? "Alternatif arac onayi bekleniyor." : "Rota penceresi musteri tarafinda teyitli." },
        new() { Durak = "Donus ve kapatma", ZamanPenceresi = "11:00 - 11:30", Durum = "Bekliyor", DurumTonu = "warning", Not = "Yuk bosaltim raporu ile kapanis yapilacak." }
      ],
      ZamanAkisi =
      [
        new() { Baslik = "Rota atamasi yapildi", Aciklama = "Gunluk kapasite toplantisinda arac bu sevkiyata ayrildi.", Zaman = "Bugun 06:10", Ikon = "bx-map-pin" },
        new() { Baslik = "Yukleme tamamlandi", Aciklama = "Depo ekibi kalite etiketi ve urun sicaklik kaydini tamamladi.", Zaman = "Bugun 06:52", Ikon = "bx-box" },
        new() { Baslik = "Canli durum guncellendi", Aciklama = arac.OperasyonNotu, Zaman = arac.SonGuncelleme, Ikon = "bx-radar" }
      ]
    };
  }
}
