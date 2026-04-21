namespace PazarCep.Areas.ETicaret.Models;

public sealed class MusteriDizinSayfaViewModel
{
  public required string SayfaBasligi { get; init; }
  public required string SayfaAciklamasi { get; init; }
  public required IReadOnlyList<MusteriOzetKartViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<string> HizliFiltreler { get; init; }
  public required IReadOnlyList<MusteriListeSatiriViewModel> Musteriler { get; init; }
}

public sealed class MusteriListeSatiriViewModel
{
  public required int Id { get; init; }
  public required string MusteriKodu { get; init; }
  public required string TamAd { get; init; }
  public required string Sirket { get; init; }
  public required string Email { get; init; }
  public required string Telefon { get; init; }
  public required string Segment { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
  public required string Sehir { get; init; }
  public required string Temsilci { get; init; }
  public required string SonEtkilesim { get; init; }
  public required string SonSiparis { get; init; }
  public required string YasamBoyuDeger { get; init; }
  public required string MemnuniyetPuani { get; init; }
  public required string AcikSiparis { get; init; }
}

public abstract class MusteriDetaySayfaViewModel
{
  public required MusteriDetayKabukViewModel Kabuk { get; init; }
}

public sealed class MusteriDetayKabukViewModel
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
  public required string SayfaBasligi { get; init; }
  public required string SayfaAciklamasi { get; init; }
  public required string AktifSekme { get; init; }
  public required IReadOnlyList<string> Etiketler { get; init; }
  public required IReadOnlyList<MusteriOzetKartViewModel> HeroKartlari { get; init; }
  public required IReadOnlyList<MusteriDetaySekmeViewModel> Sekmeler { get; init; }
}

public sealed class MusteriDetaySekmeViewModel
{
  public required string Anahtar { get; init; }
  public required string Baslik { get; init; }
  public required string Action { get; init; }
  public required string Ikon { get; init; }
}

public sealed class MusteriOzetKartViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ikon { get; init; }
  public required string Ton { get; init; }
}

public sealed class MusteriGenelBakisSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriOzetKartViewModel> PerformansKartlari { get; init; }
  public required IReadOnlyList<MusteriZamanCizelgesiOgesiViewModel> SonAktiviteler { get; init; }
  public required IReadOnlyList<MusteriDurumSatiriViewModel> HesapSagligi { get; init; }
  public required IReadOnlyList<MusteriSiparisOzetiViewModel> SonSiparisler { get; init; }
}

public sealed class MusteriZamanCizelgesiOgesiViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Zaman { get; init; }
  public required string Ikon { get; init; }
  public required string Ton { get; init; }
}

public sealed class MusteriDurumSatiriViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ton { get; init; }
}

public sealed class MusteriSiparisOzetiViewModel
{
  public required string SiparisNo { get; init; }
  public required string Tarih { get; init; }
  public required string Kanal { get; init; }
  public required string Tutar { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
}

public sealed class MusteriBilgilerSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriBilgiGrubuViewModel> BilgiGruplari { get; init; }
  public required IReadOnlyList<MusteriYetkiliViewModel> Yetkililer { get; init; }
  public required IReadOnlyList<MusteriOzetKartViewModel> DurumKartlari { get; init; }
}

public sealed class MusteriBilgiGrubuViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<MusteriBilgiAlaniViewModel> Alanlar { get; init; }
}

public sealed class MusteriBilgiAlaniViewModel
{
  public required string Etiket { get; init; }
  public required string Deger { get; init; }
  public string? YardimMetni { get; init; }
  public string GridSinifi { get; init; } = "col-md-6";
}

public sealed class MusteriYetkiliViewModel
{
  public required string AdSoyad { get; init; }
  public required string Rol { get; init; }
  public required string Email { get; init; }
  public required string Telefon { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
}

public sealed class MusteriAdresFaturalandirmaSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriAdresKartViewModel> Adresler { get; init; }
  public required IReadOnlyList<MusteriBilgiGrubuViewModel> FaturaPanelleri { get; init; }
  public required IReadOnlyList<MusteriFaturaKaydiViewModel> SonFaturalar { get; init; }
}

public sealed class MusteriAdresKartViewModel
{
  public required string Baslik { get; init; }
  public required string Tip { get; init; }
  public required string Alici { get; init; }
  public required string AdresSatiri { get; init; }
  public required string IlceIl { get; init; }
  public required string VergiBilgisi { get; init; }
  public required string Not { get; init; }
  public bool Varsayilan { get; init; }
}

public sealed class MusteriFaturaKaydiViewModel
{
  public required string FaturaNo { get; init; }
  public required string Tutar { get; init; }
  public required string Vade { get; init; }
  public required string Yontem { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
}

public sealed class MusteriBildirimlerSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriOzetKartViewModel> KanalKartlari { get; init; }
  public required IReadOnlyList<MusteriBildirimTercihGrubuViewModel> TercihGruplari { get; init; }
  public required IReadOnlyList<MusteriBildirimKaydiViewModel> SonBildirimler { get; init; }
}

public sealed class MusteriBildirimTercihGrubuViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<MusteriBildirimTercihiViewModel> Tercihler { get; init; }
}

public sealed class MusteriBildirimTercihiViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public bool Eposta { get; init; }
  public bool Sms { get; init; }
  public bool Push { get; init; }
  public bool Uygulama { get; init; }
}

public sealed class MusteriBildirimKaydiViewModel
{
  public required string Baslik { get; init; }
  public required string Kanal { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
  public required string Tarih { get; init; }
  public required string Ozet { get; init; }
}

public sealed class MusteriYorumYonetimiSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriOzetKartViewModel> ModerasyonKartlari { get; init; }
  public required IReadOnlyList<MusteriYorumKaydiViewModel> Yorumlar { get; init; }
}

public sealed class MusteriYorumKaydiViewModel
{
  public required string Urun { get; init; }
  public required string Kanal { get; init; }
  public required string Tarih { get; init; }
  public required int Puan { get; init; }
  public required string Baslik { get; init; }
  public required string Icerik { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
  public required string ModerasyonNotu { get; init; }
}

public sealed class MusteriYonlendirmelerSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriOzetKartViewModel> ProgramKartlari { get; init; }
  public required IReadOnlyList<MusteriYonlendirmeKaydiViewModel> Yonlendirmeler { get; init; }
  public required IReadOnlyList<MusteriProgramAdimiViewModel> ProgramAdimlari { get; init; }
}

public sealed class MusteriYonlendirmeKaydiViewModel
{
  public required string AdSoyad { get; init; }
  public required string Kanal { get; init; }
  public required string KayitDurumu { get; init; }
  public required string DurumSinifi { get; init; }
  public required string Tarih { get; init; }
  public required string DonusumDegeri { get; init; }
  public required string Not { get; init; }
}

public sealed class MusteriProgramAdimiViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
}

public sealed class MusteriGuvenlikSayfaViewModel : MusteriDetaySayfaViewModel
{
  public required IReadOnlyList<MusteriOzetKartViewModel> RiskKartlari { get; init; }
  public required IReadOnlyList<MusteriGuvenlikKontroluViewModel> Kontroller { get; init; }
  public required IReadOnlyList<MusteriOturumKaydiViewModel> Oturumlar { get; init; }
  public required IReadOnlyList<MusteriDenetimKaydiViewModel> DenetimKayitlari { get; init; }
}

public sealed class MusteriGuvenlikKontroluViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Durum { get; init; }
  public required string DurumSinifi { get; init; }
  public required string EylemMetni { get; init; }
}

public sealed class MusteriOturumKaydiViewModel
{
  public required string Cihaz { get; init; }
  public required string Konum { get; init; }
  public required string IpAdresi { get; init; }
  public required string SonAktivite { get; init; }
  public bool MevcutOturum { get; init; }
}

public sealed class MusteriDenetimKaydiViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Zaman { get; init; }
  public required string Ton { get; init; }
}
