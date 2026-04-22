using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PazarCep.Areas.ETicaret.Models;

namespace PazarCep.Areas.ETicaret.Controllers;

[Area("ETicaret")]
public class UrunlerController : Controller
{
  public IActionResult Liste()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Katalog verisi";

    var urunler = GetOrnekUrunler();

    var model = new UrunListeViewModel
    {
      ToplamUrun = urunler.Count,
      AktifUrun = urunler.Count(x => x.Durum == "Aktif"),
      KritikStokUrun = urunler.Count(x => x.StokMiktari <= 25),
      OrtalamaSepetTutari = 462.75m,
      Urunler = urunler
    };

    return View(model);
  }

  [HttpGet]
  public IActionResult Ekle()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Ürün formu";
    return View(CreateUrunEkleModel());
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult Ekle(UrunEkleViewModel model)
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Ürün formu";

    if (!ModelState.IsValid)
    {
      var invalidModel = CreateUrunEkleModel();
      invalidModel.UrunAdi = model.UrunAdi;
      invalidModel.Kategori = model.Kategori;
      invalidModel.StokKodu = model.StokKodu;
      invalidModel.SatisFiyati = model.SatisFiyati;
      invalidModel.IndirimliFiyat = model.IndirimliFiyat;
      invalidModel.StokMiktari = model.StokMiktari;
      invalidModel.KritikStokSeviyesi = model.KritikStokSeviyesi;
      invalidModel.Birim = model.Birim;
      invalidModel.KisaAciklama = model.KisaAciklama;
      invalidModel.Aciklama = model.Aciklama;
      invalidModel.VitrindeGoster = model.VitrindeGoster;
      invalidModel.KargoUygun = model.KargoUygun;
      return View(invalidModel);
    }

    TempData["SuccessMessage"] = $"{model.UrunAdi} ürünü başarıyla kaydedildi.";
    return RedirectToAction(nameof(Liste));
  }

  public IActionResult Kategoriler()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Kategori yönetimi";
    return View(CommerceWorkspaceFactory.CreateCategoryManagement());
  }

  private static UrunEkleViewModel CreateUrunEkleModel() => new()
  {
    KategoriSecenekleri =
    [
      new SelectListItem("Meyve", "Meyve"),
      new SelectListItem("Sebze", "Sebze"),
      new SelectListItem("Bakliyat", "Bakliyat"),
      new SelectListItem("Süt & Kahvaltılık", "SutKahvaltilik"),
      new SelectListItem("Kuruyemiş", "Kuruyemis")
    ],
    BirimSecenekleri =
    [
      new SelectListItem("kg", "kg"),
      new SelectListItem("adet", "adet"),
      new SelectListItem("paket", "paket"),
      new SelectListItem("koli", "koli")
    ]
  };

  private static List<UrunKartViewModel> GetOrnekUrunler() =>
  [
    new() { Id = 1001, UrunAdi = "Organik Domates", Kategori = "Sebze", Marka = "PazarCep Çiftçi", Fiyat = 42.90m, Birim = "kg", StokMiktari = 185, Durum = "Aktif", Puan = 4.8, SiparisAdedi = 243, GuncellenmeTarihi = DateTime.UtcNow.AddHours(-3) },
    new() { Id = 1002, UrunAdi = "Amasya Elması", Kategori = "Meyve", Marka = "Yöresel Bahçe", Fiyat = 38.50m, Birim = "kg", StokMiktari = 22, Durum = "Aktif", Puan = 4.6, SiparisAdedi = 177, GuncellenmeTarihi = DateTime.UtcNow.AddHours(-7) },
    new() { Id = 1003, UrunAdi = "Doğal Zeytinyağı", Kategori = "Bakliyat", Marka = "Ege Hasat", Fiyat = 289.00m, Birim = "adet", StokMiktari = 48, Durum = "Taslak", Puan = 4.9, SiparisAdedi = 90, GuncellenmeTarihi = DateTime.UtcNow.AddDays(-1) },
    new() { Id = 1004, UrunAdi = "Köy Yumurtası (15'li)", Kategori = "Süt & Kahvaltılık", Marka = "Anadolu Çiftliği", Fiyat = 124.90m, Birim = "paket", StokMiktari = 310, Durum = "Aktif", Puan = 4.7, SiparisAdedi = 352, GuncellenmeTarihi = DateTime.UtcNow.AddHours(-1) },
    new() { Id = 1005, UrunAdi = "Çiğ Badem", Kategori = "Kuruyemiş", Marka = "Doğal Kuruyemiş", Fiyat = 410.00m, Birim = "kg", StokMiktari = 15, Durum = "Pasif", Puan = 4.5, SiparisAdedi = 41, GuncellenmeTarihi = DateTime.UtcNow.AddDays(-2) }
  ];
}
