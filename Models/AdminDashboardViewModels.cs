namespace PazarCep.Models;

public sealed class AdminDashboardViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<AdminMetricCardViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<AdminAlertItemViewModel> Uyarilar { get; init; }
  public required IReadOnlyList<AdminQueueItemViewModel> IsListesi { get; init; }
  public required IReadOnlyList<AdminModuleCardViewModel> Moduller { get; init; }
  public required IReadOnlyList<AdminTimelineItemViewModel> ZamanAkisi { get; init; }
  public required IReadOnlyList<AdminQuickLinkViewModel> HizliBaglantilar { get; init; }
}

public sealed class AdminMetricCardViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Trend { get; init; }
  public required string Ikon { get; init; }
}

public sealed class AdminAlertItemViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Ton { get; init; }
  public required string EylemMetni { get; init; }
  public required string EylemLinki { get; init; }
}

public sealed class AdminQueueItemViewModel
{
  public required string Baslik { get; init; }
  public required string Takim { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string SonTarih { get; init; }
  public required string Aciklama { get; init; }
}

public sealed class AdminModuleCardViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string SaglikDurumu { get; init; }
  public required string SaglikTonu { get; init; }
  public required int TamamlanmaYuzdesi { get; init; }
  public required string LinkMetni { get; init; }
  public required string Link { get; init; }
}

public sealed class AdminTimelineItemViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Zaman { get; init; }
  public required string Ikon { get; init; }
}

public sealed class AdminQuickLinkViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Link { get; init; }
  public required string Ikon { get; init; }
}

public static class AdminDashboardFactory
{
  public static AdminDashboardViewModel Create()
  {
    return new()
    {
      Baslik = "Operasyon kontrol merkezi",
      Aciklama = "E-ticaret, lojistik, CRM ve randevu akışlarını tek ekranda izleyin. Öncelikli işleri sıraya alın, riskleri görün ve modüller arası koordinasyonu kaybetmeden yönetin.",
      OzetKartlar =
      [
        new() { Baslik = "Aktif sipariş akışı", Deger = "128", Aciklama = "Bugün operasyonda olan sipariş sayısı", Trend = "+14 yeni sipariş / son 24 saat", Ikon = "bx-package" },
        new() { Baslik = "Zaman penceresi kritik", Deger = "7", Aciklama = "Teslimat veya randevu riski taşıyan kayıt", Trend = "2 kayıt lojistik yeniden planlama bekliyor", Ikon = "bx-timer" },
        new() { Baslik = "İzlenen müşteri", Deger = "18", Aciklama = "Tahsilat, memnuniyet veya churn riski olan hesap", Trend = "4 hesap bugün müşteri ekibinde", Ikon = "bx-user-voice" },
        new() { Baslik = "Modül tamamlama", Deger = "%86", Aciklama = "Bu ön izleme fazında kurumsal tamamlama seviyesi", Trend = "Ana akışlar ürünleştirildi, son kalite geçişi sürüyor", Ikon = "bx-check-circle" }
      ],
      Uyarilar =
      [
        new() { Baslik = "Lojistik yeniden planlama gerekli", Ozet = "Ankara ve Bursa çıkışlı iki rota için teslimat penceresi sıkıştı. Randevu ve filo ekranı birlikte kontrol edilmeli.", Ton = "warning", EylemMetni = "Lojistiğe git", EylemLinki = "/Lojistik/AnaSayfa/Index" },
        new() { Baslik = "Tahsilat riski olan müşteri grubu", Ozet = "Kritik segmentteki üç müşteri için finans ve temsilci notları aynı çalışma alanında toplanmalı.", Ton = "danger", EylemMetni = "Müşteri alanını aç", EylemLinki = "/ETicaret/Musteri/TumMusteriler" },
        new() { Baslik = "Bugün 9 randevu slotu dolu", Ozet = "Teslim alma ve yükleme randevularında kapasite dengesi korunuyor, iki slot onay bekliyor.", Ton = "info", EylemMetni = "Randevu panosunu aç", EylemLinki = "/ETicaret/Randevu/Index" }
      ],
      IsListesi =
      [
        new() { Baslik = "Kritik stok alarmı olan ürünleri gözden geçir", Takim = "E-Ticaret", Durum = "2026.05.02", DurumTonu = "warning", SonTarih = "2026.05.02 10:30", Aciklama = "Katalogta kritik seviye altına düşen 5 ürün için tedarik aksiyonu planlanmalı." },
        new() { Baslik = "Sabah sevkiyat slotlarını doğrula", Takim = "Lojistik", Durum = "Öncelikli", DurumTonu = "danger", SonTarih = "2026.05.02 11:00", Aciklama = "Soğuk zincir ürünler için kapı ve araç atamaları kapatılmadan rota kilitlenmemeli." },
        new() { Baslik = "CRM takip listesini temsilcilere dağıt", Takim = "Müşteri Yönetimi", Durum = "Planlandı", DurumTonu = "info", SonTarih = "2026.05.02 13:00", Aciklama = "Takip gereken müşteriler için bugün aksiyon sahibi netleştirilmeli." },
        new() { Baslik = "Haftalık yönetim özeti hazırlanıyor", Takim = "Panel", Durum = "Yolda", DurumTonu = "success", SonTarih = "2026.05.02 16:00", Aciklama = "Canlı ön izleme için modül bazlı görsel kalite ve operatif durum notları toparlanıyor." }
      ],
      Moduller =
      [
        new() { Baslik = "E-Ticaret operasyonu", Ozet = "Katalog, sipariş ve müşteri çalışma alanı birbiriyle hizalandı.", SaglikDurumu = "Güçlü", SaglikTonu = "success", TamamlanmaYuzdesi = 90, LinkMetni = "Operasyon özetine git", Link = "/ETicaret/AnaSayfa/Index" },
        new() { Baslik = "Lojistik yönetimi", Ozet = "Filo ve sevkiyat akışı artık panel kalitesinde okunabilir durumda.", SaglikDurumu = "İyileştirildi", SaglikTonu = "info", TamamlanmaYuzdesi = 84, LinkMetni = "Lojistik paneli aç", Link = "/Lojistik/AnaSayfa/Index" },
        new() { Baslik = "CRM ve destek", Ozet = "Yönetim ekranları operasyon özetleri ve aksiyon netliğiyle güçlendirildi.", SaglikDurumu = "Stabil", SaglikTonu = "success", TamamlanmaYuzdesi = 82, LinkMetni = "CRM alanına git", Link = "/MusteriYonetimi/AnaSayfa/Index" },
        new() { Baslik = "Randevu planlama", Ozet = "Yükleme ve teslim alma slotları artık ayrı bir iş akışı olarak görünür.", SaglikDurumu = "Yeni", SaglikTonu = "warning", TamamlanmaYuzdesi = 76, LinkMetni = "Randevu panosunu aç", Link = "/ETicaret/Randevu/Index" }
      ],
      ZamanAkisi =
      [
        new() { Baslik = "Sabah dağıtımı kilitlendi", Aciklama = "07:00 - 09:00 arası teslimat slotları operasyon ekibi tarafından teyit edildi.", Zaman = "2026.05.02 08:40", Ikon = "bx-check-circle" },
        new() { Baslik = "Katalog uyarısı oluştu", Aciklama = "İki ürün kritik stok seviyesine düştü ve liste ekranına işaret bırakıldı.", Zaman = "2026.05.02 09:15", Ikon = "bx-error-circle" },
        new() { Baslik = "Müşteri temsilcisi notu eklendi", Aciklama = "Kurumsal segmentteki bir hesap için vade revizyonu talebi işlendi.", Zaman = "2026.05.02 10:05", Ikon = "bx-note" },
        new() { Baslik = "Ön izleme kalite geçişi güncellendi", Aciklama = "Paylaşılan layout, mobil davranış ve iş modülü tutarlılığı tek standarda çekildi.", Zaman = "2026.05.02 11:10", Ikon = "bx-rocket" }
      ],
      HizliBaglantilar =
      [
        new() { Baslik = "Sipariş merkezini aç", Ozet = "Sipariş listesi, detay akışı ve bekleyen iş yükünü yönetin.", Link = "/ETicaret/Emir/SiparisListesi", Ikon = "bx-package" },
        new() { Baslik = "Müşteri çalışma alanı", Ozet = "CRM, bildirim, güvenlik ve yönlendirme süreçlerini denetleyin.", Link = "/ETicaret/Musteri/TumMusteriler", Ikon = "bx-group" },
        new() { Baslik = "Filo görünümü", Ozet = "Araç durumu, rota ve kilometre takibini tek yerden sürdürün.", Link = "/Lojistik/Filo/Index", Ikon = "bx-car" }
      ]
    };
  }
}
