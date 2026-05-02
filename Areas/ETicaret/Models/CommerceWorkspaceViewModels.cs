namespace PazarCep.Areas.ETicaret.Models;

public sealed class CommerceMetricCardViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ikon { get; init; }
}

public sealed class CommerceAlertViewModel
{
  public required string Baslik { get; init; }
  public required string Ozet { get; init; }
  public required string Ton { get; init; }
  public required string EylemLinki { get; init; }
  public required string EylemMetni { get; init; }
}

public sealed class CommercePipelineStageViewModel
{
  public required string Baslik { get; init; }
  public required string Deger { get; init; }
  public required string Aciklama { get; init; }
  public required string Ton { get; init; }
}

public sealed class CommerceProductFocusViewModel
{
  public required string UrunAdi { get; init; }
  public required string Kategori { get; init; }
  public required string Fiyat { get; init; }
  public required string StokOzeti { get; init; }
  public required string Puan { get; init; }
  public required string Trend { get; init; }
}

public sealed class CommerceAppointmentItemViewModel
{
  public required string Baslik { get; init; }
  public required string Musteri { get; init; }
  public required string Zaman { get; init; }
  public required string Konum { get; init; }
  public required string Durum { get; init; }
  public required string Ton { get; init; }
}

public sealed class CommerceOverviewPageViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<CommerceMetricCardViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<CommerceAlertViewModel> Uyarilar { get; init; }
  public required IReadOnlyList<CommercePipelineStageViewModel> SiparisAkisi { get; init; }
  public required IReadOnlyList<CommerceProductFocusViewModel> OneCikanUrunler { get; init; }
  public required IReadOnlyList<CommerceAppointmentItemViewModel> BugunkuRandevular { get; init; }
}

public sealed class OrderListItemViewModel
{
  public required int Id { get; init; }
  public required string SiparisNo { get; init; }
  public required string Musteri { get; init; }
  public required string Kanal { get; init; }
  public required string Tutar { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string SevkPenceresi { get; init; }
  public required string Temsilci { get; init; }
  public required string Rota { get; init; }
  public required string Ozet { get; init; }
}

public sealed class OrderListPageViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<CommerceMetricCardViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<OrderListItemViewModel> Siparisler { get; init; }
}

public sealed class OrderLineItemViewModel
{
  public required string Urun { get; init; }
  public required string Miktar { get; init; }
  public required string BirimFiyat { get; init; }
  public required string AraToplam { get; init; }
}

public sealed class OrderTimelineItemViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required string Zaman { get; init; }
  public required string Ikon { get; init; }
}

public sealed class OrderDetailPageViewModel
{
  public required int Id { get; init; }
  public required string SiparisNo { get; init; }
  public required string Musteri { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
  public required string ToplamTutar { get; init; }
  public required string Kanal { get; init; }
  public required string TeslimatPenceresi { get; init; }
  public required string OdemeYontemi { get; init; }
  public required string Temsilci { get; init; }
  public required string SevkiyatRota { get; init; }
  public required string RandevuOzeti { get; init; }
  public required IReadOnlyList<CommerceMetricCardViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<OrderLineItemViewModel> Kalemler { get; init; }
  public required IReadOnlyList<OrderTimelineItemViewModel> Akis { get; init; }
}

public sealed class CategoryManagementItemViewModel
{
  public required string Ad { get; init; }
  public required string Aciklama { get; init; }
  public required string Komisyon { get; init; }
  public required string Sahip { get; init; }
  public required int UrunSayisi { get; init; }
  public required string Durum { get; init; }
  public required string DurumTonu { get; init; }
}

public sealed class CategoryManagementPageViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<CommerceMetricCardViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<CategoryManagementItemViewModel> Kategoriler { get; init; }
}

public sealed class AppointmentSlotViewModel
{
  public required string SaatAraligi { get; init; }
  public required string Baslik { get; init; }
  public required string Konum { get; init; }
  public required string Durum { get; init; }
  public required string Ton { get; init; }
  public required string Doluluk { get; init; }
}

public sealed class AppointmentRecordViewModel
{
  public required string Kod { get; init; }
  public required string Tip { get; init; }
  public required string Musteri { get; init; }
  public required string Zaman { get; init; }
  public required string Konum { get; init; }
  public required string Durum { get; init; }
  public required string Ton { get; init; }
  public required string Ozet { get; init; }
}

public sealed class AppointmentBoardPageViewModel
{
  public required string Baslik { get; init; }
  public required string Aciklama { get; init; }
  public required IReadOnlyList<CommerceMetricCardViewModel> OzetKartlar { get; init; }
  public required IReadOnlyList<AppointmentSlotViewModel> Slotlar { get; init; }
  public required IReadOnlyList<AppointmentRecordViewModel> Kayitlar { get; init; }
}

public sealed class AppointmentCalendarItemViewModel
{
  public required string Id { get; init; }
  public required string Title { get; init; }
  public required string TypeKey { get; init; }
  public required string TypeText { get; init; }
  public required string StatusKey { get; init; }
  public required string StatusText { get; init; }
  public required DateTime StartTime { get; init; }
  public DateTime? EndTime { get; init; }
  public required string RelatedParty { get; init; }
  public required string Location { get; init; }
  public required string Description { get; init; }
  public required string BadgeCssClass { get; init; }
  public required string TypeCssClass { get; init; }
}

public sealed class AppointmentCalendarDayViewModel
{
  public required DateTime Date { get; init; }
  public required bool IsToday { get; init; }
  public required bool IsSelected { get; init; }
  public required bool IsCurrentMonth { get; init; }
  public required IReadOnlyList<AppointmentCalendarItemViewModel> Appointments { get; init; }
}

public sealed class AppointmentSummaryViewModel
{
  public required int TodayAppointments { get; init; }
  public required int PendingApprovals { get; init; }
  public required int ThisWeekPlans { get; init; }
  public required int CompletedOperations { get; init; }
}

public sealed class AppointmentCalendarViewModel
{
  public required DateTime CurrentMonth { get; init; }
  public required DateTime PreviousMonth { get; init; }
  public required DateTime NextMonth { get; init; }
  public required DateTime SelectedDate { get; init; }
  public required IReadOnlyList<AppointmentCalendarDayViewModel> Days { get; init; }
  public required IReadOnlyList<AppointmentCalendarItemViewModel> SelectedDayAppointments { get; init; }
  public required IReadOnlyList<AppointmentCalendarItemViewModel> UpcomingAppointments { get; init; }
  public required AppointmentSummaryViewModel Summary { get; init; }
}

public static class CommerceWorkspaceFactory
{
  public static CommerceOverviewPageViewModel CreateOverview()
  {
    return new()
    {
      Baslik = "E-ticaret operasyon özeti",
      Aciklama = "Katalog kalitesi, sipariş akışı, müşteri hareketi ve randevu planlamayı tek bir ticari kontrol yüzeyinde yönetin.",
      OzetKartlar =
      [
        new() { Baslik = "Aktif katalog", Deger = "148 ürün", Aciklama = "Satışa açık, görünür ve stoklu ürünler", Ikon = "bx-box" },
        new() { Baslik = "Bugünkü sipariş", Deger = "36", Aciklama = "Yeni açılan ve işleme alınan sipariş", Ikon = "bx-package" },
        new() { Baslik = "Kritik stok", Deger = "5 ürün", Aciklama = "Tedarik planı gerektiren katalog başlığı", Ikon = "bx-error-circle" },
        new() { Baslik = "Planlı randevu", Deger = "9 slot", Aciklama = "Yükleme ve teslim alma planı", Ikon = "bx-calendar-check" }
      ],
      Uyarilar =
      [
        new() { Baslik = "Sabah sevkiyatlarında kapasite daralıyor", Ozet = "Soğuk zincir ürünlerinin üçü aynı teslim penceresine yığıldı. Lojistik ve randevu panoları birlikte gözden geçirilmeli.", Ton = "warning", EylemLinki = "/ETicaret/Randevu/Index", EylemMetni = "Randevuları aç" },
        new() { Baslik = "İki ürün kritik stokta", Ozet = "Amasya Elması ve Çiğ Badem için alternatif tedarik veya görünürlük güncellemesi bekleniyor.", Ton = "danger", EylemLinki = "/ETicaret/Urunler/Liste", EylemMetni = "Kataloğu gözden geçir" },
        new() { Baslik = "Kurumsal müşteri fırsatı", Ozet = "VIP segmentte bir hesap yeni kategori açılışı için teklif bekliyor.", Ton = "info", EylemLinki = "/ETicaret/Musteri/TumMusteriler", EylemMetni = "Müşteri alanına git" }
      ],
      SiparisAkisi =
      [
        new() { Baslik = "Yeni sipariş", Deger = "12", Aciklama = "Henüz operasyon sahibine dağıtılmadı", Ton = "info" },
        new() { Baslik = "Hazırlanıyor", Deger = "9", Aciklama = "Paketleme ve kalite kontrol aşamasında", Ton = "warning" },
        new() { Baslik = "Sevke hazır", Deger = "8", Aciklama = "Araç ve slot eşleşmesi tamamlandı", Ton = "success" },
        new() { Baslik = "Takip gereken", Deger = "3", Aciklama = "Stok veya lojistik uyarısı taşıyor", Ton = "danger" }
      ],
      OneCikanUrunler =
      [
        new() { UrunAdi = "Organik Domates", Kategori = "Sebze", Fiyat = "₺42,90 / kg", StokOzeti = "185 kg stok · güçlü görünürlük", Puan = "4,8 / 5", Trend = "Sipariş hacmi son 7 günde %11 arttı" },
        new() { UrunAdi = "Köy Yumurtası (15'li)", Kategori = "Süt & Kahvaltılık", Fiyat = "₺124,90 / paket", StokOzeti = "310 paket · sabit tedarik", Puan = "4,7 / 5", Trend = "Kurumsal kahvaltı segmentinde öne çıkıyor" },
        new() { UrunAdi = "Amasya Elması", Kategori = "Meyve", Fiyat = "₺38,50 / kg", StokOzeti = "22 kg stok · alarm seviyesi", Puan = "4,6 / 5", Trend = "Düşük stok nedeniyle görünürlük uyarısı var" }
      ],
      BugunkuRandevular =
      [
        new() { Baslik = "Sabah yükleme slotu", Musteri = "Kaya Restoran Grubu", Zaman = "07:30 - 08:15", Konum = "Kadıköy soğuk oda", Durum = "Onaylandı", Ton = "success" },
        new() { Baslik = "Teslim alma randevusu", Musteri = "Demir Organik", Zaman = "09:30 - 10:00", Konum = "Ankara transfer noktası", Durum = "Hazırlanıyor", Ton = "warning" },
        new() { Baslik = "Kurumsal depo kabulü", Musteri = "Işık Marketler Zinciri", Zaman = "11:00 - 11:45", Konum = "Bursa merkez depo", Durum = "Teyit bekliyor", Ton = "info" }
      ]
    };
  }

  public static OrderListPageViewModel CreateOrderList()
  {
    return new()
    {
      Baslik = "Sipariş operasyon listesi",
      Aciklama = "Siparişleri kanal, zaman penceresi ve operasyon riski bazında takip edin. Masaüstünde yoğun tablo, mobilde karar odaklı kart görünümü sunulur.",
      OzetKartlar =
      [
        new() { Baslik = "Açık sipariş", Deger = "24", Aciklama = "İşlemde, hazırlıkta veya sevkte olan sipariş", Ikon = "bx-package" },
        new() { Baslik = "Bugün teslim", Deger = "11", Aciklama = "Aynı gün tamamlanması gereken kayıt", Ikon = "bx-truck" },
        new() { Baslik = "Randevulu akış", Deger = "9", Aciklama = "Saat penceresi tanımlı siparişler", Ikon = "bx-calendar" },
        new() { Baslik = "Riskli sipariş", Deger = "3", Aciklama = "Stok veya lojistik uyarısı taşıyan kayıt", Ikon = "bx-error" }
      ],
      Siparisler =
      [
        new() { Id = 50124, SiparisNo = "SC-50124", Musteri = "Kaya Restoran Grubu", Kanal = "Mobil", Tutar = "₺12.450", Durum = "Hazırlanıyor", DurumTonu = "warning", SevkPenceresi = "07:00 - 09:00", Temsilci = "Deniz Şahin", Rota = "Kadıköy · Soğuk zincir", Ozet = "Sebze ve yumurta kalemleri paketleme aşamasında." },
        new() { Id = 50111, SiparisNo = "SC-50111", Musteri = "Demir Organik", Kanal = "Web", Tutar = "₺8.940", Durum = "Sevke hazır", DurumTonu = "success", SevkPenceresi = "10:00 - 12:00", Temsilci = "Ece Yıldırım", Rota = "Çankaya · Kapı teslim", Ozet = "Araç ve randevu eşleşmesi tamamlandı." },
        new() { Id = 50098, SiparisNo = "SC-50098", Musteri = "Işık Marketler Zinciri", Kanal = "Temsilci", Tutar = "₺19.260", Durum = "Yeni sipariş", DurumTonu = "info", SevkPenceresi = "13:00 - 15:00", Temsilci = "Burcu Tan", Rota = "Nilüfer · Depo kabul", Ozet = "Kurumsal zincir siparişi, kalite kontrol etiketi bekliyor." },
        new() { Id = 50087, SiparisNo = "SC-50087", Musteri = "Aksoy Catering", Kanal = "Mobil", Tutar = "₺6.380", Durum = "Takip gerekli", DurumTonu = "danger", SevkPenceresi = "16:00 - 18:00", Temsilci = "Deniz Şahin", Rota = "Bornova · Alternatif ürün onayı", Ozet = "İki kalemde stok alternatifi müşteri onayı bekliyor." }
      ]
    };
  }

  public static OrderDetailPageViewModel CreateOrderDetail(int? id)
  {
    var orderId = id ?? 50124;

    return new()
    {
      Id = orderId,
      SiparisNo = $"SC-{orderId}",
      Musteri = "Kaya Restoran Grubu",
      Durum = "Hazırlanıyor",
      DurumTonu = "warning",
      ToplamTutar = "₺12.450",
      Kanal = "Mobil sipariş",
      TeslimatPenceresi = "22 Nisan 2026 · 07:00 - 09:00",
      OdemeYontemi = "Kurumsal havale",
      Temsilci = "Deniz Şahin",
      SevkiyatRota = "Kadıköy merkez · soğuk zincir",
      RandevuOzeti = "08:00 yükleme slotu onaylı, araç ataması lojistik paneli ile senkron.",
      OzetKartlar =
      [
        new() { Baslik = "Sipariş tutarı", Deger = "₺12.450", Aciklama = "İskonto dahil toplam", Ikon = "bx-wallet" },
        new() { Baslik = "Toplam kalem", Deger = "4", Aciklama = "Aktif ürün satırı", Ikon = "bx-list-ul" },
        new() { Baslik = "Planlı sevk", Deger = "07:00 - 09:00", Aciklama = "Teslimat penceresi", Ikon = "bx-time" },
        new() { Baslik = "Durum riski", Deger = "Orta", Aciklama = "Alternatif ürün onayı beklenmiyor", Ikon = "bx-shield-quarter" }
      ],
      Kalemler =
      [
        new() { Urun = "Organik Domates", Miktar = "120 kg", BirimFiyat = "₺42,90", AraToplam = "₺5.148" },
        new() { Urun = "Köy Yumurtası (15'li)", Miktar = "30 paket", BirimFiyat = "₺124,90", AraToplam = "₺3.747" },
        new() { Urun = "Amasya Elması", Miktar = "40 kg", BirimFiyat = "₺38,50", AraToplam = "₺1.540" },
        new() { Urun = "Çiğ Badem", Miktar = "5 kg", BirimFiyat = "₺403,00", AraToplam = "₺2.015" }
      ],
      Akis =
      [
        new() { Baslik = "Sipariş alındı", Aciklama = "Mobil uygulama üzerinden kurumsal sipariş oluşturuldu.", Zaman = "Bugün · 06:52", Ikon = "bx-receipt" },
        new() { Baslik = "Operasyon sahibine atandı", Aciklama = "Deniz Şahin siparişi kalite ve tedarik kontrolüne aldı.", Zaman = "Bugün · 07:05", Ikon = "bx-user-check" },
        new() { Baslik = "Randevu senkronlandı", Aciklama = "Yükleme slotu ve araç kapasitesi teyit edildi.", Zaman = "Bugün · 07:18", Ikon = "bx-calendar-check" },
        new() { Baslik = "Paketleme başladı", Aciklama = "Soğuk zincir kalemleri ayrılmış toplama listesine geçti.", Zaman = "Bugün · 07:34", Ikon = "bx-box" }
      ]
    };
  }

  public static CategoryManagementPageViewModel CreateCategoryManagement()
  {
    return new()
    {
      Baslik = "Kategori yönetimi",
      Aciklama = "Kategori sahipliği, komisyon ve görünürlük kararlarını aynı yüzeyden yönetin.",
      OzetKartlar =
      [
        new() { Baslik = "Toplam kategori", Deger = "8", Aciklama = "Aktif ve taslak kategori yapısı", Ikon = "bx-category-alt" },
        new() { Baslik = "Aktif kategori", Deger = "6", Aciklama = "Satışa açık ve görünür yapı", Ikon = "bx-check-circle" },
        new() { Baslik = "Taslak kategori", Deger = "2", Aciklama = "İçerik veya komisyon revizyonu bekliyor", Ikon = "bx-edit" },
        new() { Baslik = "Ortalama komisyon", Deger = "%8,5", Aciklama = "Kategori bazlı gelir dengesi", Ikon = "bx-pie-chart-alt-2" }
      ],
      Kategoriler =
      [
        new() { Ad = "Meyve", Aciklama = "Yüksek sirkülasyonlu taze ürün grubu.", Komisyon = "%8", Sahip = "Ticari kategori ekibi", UrunSayisi = 148, Durum = "Aktif", DurumTonu = "success" },
        new() { Ad = "Sebze", Aciklama = "Günlük operasyon yoğunluğu en yüksek kategori.", Komisyon = "%7", Sahip = "Operasyon + tedarik", UrunSayisi = 204, Durum = "Aktif", DurumTonu = "success" },
        new() { Ad = "Bakliyat", Aciklama = "Uzun ömürlü stok ve kampanya yönetimi gerektirir.", Komisyon = "%10", Sahip = "Kategori yöneticisi", UrunSayisi = 89, Durum = "Aktif", DurumTonu = "info" },
        new() { Ad = "Süt & Kahvaltılık", Aciklama = "Soğuk zincir ve teslimat penceresi eşleşmesine duyarlı.", Komisyon = "%9", Sahip = "Soğuk zincir ekibi", UrunSayisi = 62, Durum = "Taslak revizyon", DurumTonu = "warning" }
      ]
    };
  }

  public static AppointmentBoardPageViewModel CreateAppointmentBoard()
  {
    return new()
    {
      Baslik = "Randevu ve slot planlama",
      Aciklama = "Yükleme, teslim alma ve depo kabul akışlarını çakışma yaşamadan yönetin. Randevu görünümü, sipariş ve lojistik ekranlarıyla aynı dili konuşur.",
      OzetKartlar =
      [
        new() { Baslik = "Bugünkü slot", Deger = "9", Aciklama = "Takvimde planlı slot sayısı", Ikon = "bx-calendar-check" },
        new() { Baslik = "Onay bekleyen", Deger = "2", Aciklama = "Müşteri veya depo teyidi alınmamış kayıt", Ikon = "bx-time-five" },
        new() { Baslik = "Doluluk oranı", Deger = "%78", Aciklama = "Sabah ve öğle kapasitesinin ortalaması", Ikon = "bx-line-chart" },
        new() { Baslik = "Çakışma riski", Deger = "1", Aciklama = "Aynı kapıda üst üste planlanan slot", Ikon = "bx-error-circle" }
      ],
      Slotlar =
      [
        new() { SaatAraligi = "07:00 - 08:00", Baslik = "Soğuk zincir yükleme", Konum = "Kadıköy merkez depo", Durum = "Dolu", Ton = "success", Doluluk = "3/3 slot" },
        new() { SaatAraligi = "09:00 - 10:00", Baslik = "Kurumsal teslim alma", Konum = "Ankara transfer merkezi", Durum = "Kısmi", Ton = "warning", Doluluk = "2/3 slot" },
        new() { SaatAraligi = "11:00 - 12:00", Baslik = "Depo kabul", Konum = "Bursa bölge deposu", Durum = "Onay bekliyor", Ton = "info", Doluluk = "1/2 slot" }
      ],
      Kayitlar =
      [
        new() { Kod = "RND-2104", Tip = "Yükleme", Musteri = "Kaya Restoran Grubu", Zaman = "22 Nisan 2026 · 07:30", Konum = "Kadıköy merkez depo", Durum = "Onaylandı", Ton = "success", Ozet = "Sipariş SC-50124 ile bağlantılı, araç ataması tamamlandı." },
        new() { Kod = "RND-2105", Tip = "Teslim alma", Musteri = "Demir Organik", Zaman = "22 Nisan 2026 · 09:30", Konum = "Ankara transfer merkezi", Durum = "Hazırlanıyor", Ton = "warning", Ozet = "Operasyon ekibi depo giriş saatini doğruluyor." },
        new() { Kod = "RND-2106", Tip = "Depo kabul", Musteri = "Işık Marketler Zinciri", Zaman = "22 Nisan 2026 · 11:15", Konum = "Bursa bölge deposu", Durum = "Teyit bekliyor", Ton = "info", Ozet = "Zincir mağaza teslimatı için kabul ekibi onayı bekleniyor." }
      ]
    };
  }

  public static AppointmentCalendarViewModel CreateAppointmentCalendar(DateTime? month = null, DateTime? selectedDate = null)
  {
    var today = DateTime.Today;
    var currentMonth = new DateTime((month ?? selectedDate ?? today).Year, (month ?? selectedDate ?? today).Month, 1);
    var selected = (selectedDate ?? today).Date;
    var appointments = CreateAppointmentCalendarItems(today);
    var firstVisibleDay = currentMonth.AddDays(-GetMondayOffset(currentMonth));
    var days = Enumerable.Range(0, 42)
      .Select(offset =>
      {
        var date = firstVisibleDay.AddDays(offset);
        return new AppointmentCalendarDayViewModel
        {
          Date = date,
          IsToday = date == today,
          IsSelected = date == selected,
          IsCurrentMonth = date.Month == currentMonth.Month,
          Appointments = appointments
            .Where(item => item.StartTime.Date == date)
            .OrderBy(item => item.StartTime)
            .ToList()
        };
      })
      .ToList();

    var weekStart = today.AddDays(-GetMondayOffset(today));
    var weekEnd = weekStart.AddDays(7);

    return new()
    {
      CurrentMonth = currentMonth,
      PreviousMonth = currentMonth.AddMonths(-1),
      NextMonth = currentMonth.AddMonths(1),
      SelectedDate = selected,
      Days = days,
      SelectedDayAppointments = appointments
        .Where(item => item.StartTime.Date == selected)
        .OrderBy(item => item.StartTime)
        .ToList(),
      UpcomingAppointments = appointments
        .Where(item => item.StartTime >= today)
        .OrderBy(item => item.StartTime)
        .Take(7)
        .ToList(),
      Summary = new()
      {
        TodayAppointments = appointments.Count(item => item.StartTime.Date == today),
        PendingApprovals = appointments.Count(item => item.StatusKey == "PendingApproval"),
        ThisWeekPlans = appointments.Count(item => item.StartTime >= weekStart && item.StartTime < weekEnd),
        CompletedOperations = appointments.Count(item => item.StatusKey == "Completed")
      }
    };
  }

  private static int GetMondayOffset(DateTime date)
  {
    return ((int)date.DayOfWeek + 6) % 7;
  }

  private static IReadOnlyList<AppointmentCalendarItemViewModel> CreateAppointmentCalendarItems(DateTime today)
  {
    // TODO: Replace demo appointments with database-backed records and role-based filtering.
    return
    [
      CreateAppointment("RND-3001", "Sabah ürün teslim alma", "ProductPickup", "Ürün Teslim Alma", "Approved", "Onaylandı", today.AddHours(8).AddMinutes(30), today.AddHours(9).AddMinutes(15), "Yeşilova Çiftliği", "Ankara transfer noktası", "Domates ve salatalık kabulü için kalite kontrol ekibi hazır olacak."),
      CreateAppointment("RND-3002", "Market teslimat planı", "ProductDelivery", "Ürün Teslimatı", "InProgress", "Devam Ediyor", today.AddHours(11), today.AddHours(12), "Işık Marketler Zinciri", "Bursa merkez depo", "Soğuk zincir aracı depo kabul kapısına yönlendirildi."),
      CreateAppointment("RND-3003", "Üretici fiyat görüşmesi", "FarmerMeeting", "Üretici Görüşmesi", "PendingApproval", "Onay Bekliyor", today.AddDays(1).AddHours(10), today.AddDays(1).AddHours(10).AddMinutes(45), "Demir Organik", "Çankaya / Ankara", "Sezonluk kabak ve biber tedarik planı değerlendirilecek."),
      CreateAppointment("RND-3004", "Alıcı sipariş toplantısı", "BuyerMeeting", "Alıcı Görüşmesi", "Planned", "Planlandı", today.AddDays(2).AddHours(14), today.AddDays(2).AddHours(15), "Kaya Restoran Grubu", "Kadıköy / İstanbul", "Haftalık taze ürün alım takvimi ve teslimat pencereleri netleştirilecek."),
      CreateAppointment("RND-3005", "Nakliye rota eşleştirme", "LogisticsPlan", "Nakliye Planı", "Approved", "Onaylandı", today.AddDays(3).AddHours(9), today.AddDays(3).AddHours(10), "PazarCep Lojistik", "İzmir - Manisa hattı", "Boş kasa dönüşü ve ikinci teslimat durağı aynı rota üzerinde planlanacak."),
      CreateAppointment("RND-3006", "Ziraat danışmanlığı", "ConsultantMeeting", "Ziraat Danışmanlığı", "PendingApproval", "Onay Bekliyor", today.AddDays(4).AddHours(16), today.AddDays(4).AddHours(17), "Akdeniz Üretici Birliği", "Antalya / Serik", "Gübreleme programı ve hastalık gözlemi için uzman görüşmesi."),
      CreateAppointment("RND-3007", "Hasat ekibi planı", "WorkerSchedule", "İşçi / Yevmiye Planı", "Planned", "Planlandı", today.AddDays(5).AddHours(6), today.AddDays(5).AddHours(15), "Bereket Tarım", "Akhisar / Manisa", "Sekiz kişilik hasat ekibi için günlük çalışma programı oluşturuldu."),
      CreateAppointment("RND-3008", "Tamamlanan teslimat", "ProductDelivery", "Ürün Teslimatı", "Completed", "Tamamlandı", today.AddDays(-1).AddHours(13), today.AddDays(-1).AddHours(14), "Mavi Market", "Nilüfer / Bursa", "Teslimat evrakları ve soğuk zincir kontrolü tamamlandı."),
      CreateAppointment("RND-3009", "Ertelenen depo kabulü", "ProductPickup", "Ürün Teslim Alma", "Postponed", "Ertelendi", today.AddDays(7).AddHours(12), today.AddDays(7).AddHours(13), "Orta Anadolu Kooperatifi", "Konya bölge deposu", "Depo yoğunluğu nedeniyle kabul penceresi yeniden planlandı."),
      CreateAppointment("RND-3010", "İptal edilen danışmanlık", "ConsultantMeeting", "Ziraat Danışmanlığı", "Cancelled", "İptal Edildi", today.AddDays(8).AddHours(15), today.AddDays(8).AddHours(16), "Ege Seracılık", "Aydın / Söke", "Üretici talebiyle ileri tarihte yeniden planlanacak."),
      CreateAppointment("RND-3011", "Öğle teslimat penceresi", "ProductDelivery", "Ürün Teslimatı", "Approved", "Onaylandı", today.AddDays(2).AddHours(12), today.AddDays(2).AddHours(13), "Aksoy Catering", "Bornova / İzmir", "Sebze ve kahvaltılık ürünler aynı teslimat penceresinde taşınacak."),
      CreateAppointment("RND-3012", "Ek alıcı görüşmesi", "BuyerMeeting", "Alıcı Görüşmesi", "Planned", "Planlandı", today.AddDays(2).AddHours(16), today.AddDays(2).AddHours(16).AddMinutes(30), "Güneş Manav", "Meram / Konya", "Düzenli alım talebi için ürün çeşitleri görüşülecek."),
      CreateAppointment("RND-3013", "Akşam yükleme kontrolü", "LogisticsPlan", "Nakliye Planı", "Approved", "Onaylandı", today.AddDays(2).AddHours(18), today.AddDays(2).AddHours(19), "PazarCep Filo", "Bursa - İstanbul hattı", "Araç kapasitesi ve teslimat sırası kontrol edilecek.")
    ];
  }

  private static AppointmentCalendarItemViewModel CreateAppointment(
    string id,
    string title,
    string typeKey,
    string typeText,
    string statusKey,
    string statusText,
    DateTime startTime,
    DateTime? endTime,
    string relatedParty,
    string location,
    string description)
  {
    return new()
    {
      Id = id,
      Title = title,
      TypeKey = typeKey,
      TypeText = typeText,
      StatusKey = statusKey,
      StatusText = statusText,
      StartTime = startTime,
      EndTime = endTime,
      RelatedParty = relatedParty,
      Location = location,
      Description = description,
      BadgeCssClass = statusKey switch
      {
        "Approved" or "Completed" => "success",
        "PendingApproval" or "Postponed" => "warning",
        "Cancelled" => "danger",
        "InProgress" => "info",
        _ => "neutral"
      },
      TypeCssClass = typeKey switch
      {
        "ProductPickup" => "pickup",
        "ProductDelivery" => "delivery",
        "FarmerMeeting" => "farmer",
        "BuyerMeeting" => "buyer",
        "LogisticsPlan" => "logistics",
        "ConsultantMeeting" => "consultant",
        "WorkerSchedule" => "worker",
        _ => "default"
      }
    };
  }
}
