using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class MusterilerController : Controller
{
  public IActionResult Index()
  {
    // Demo veri (sonradan DB'den gelecek)
    var liste = new List<MusteriListeSatiriVM>
        {
            new() { Id = 1, AdSoyadUnvan = "Ahmet Yılmaz", Telefon="05xx xxx xx xx", Eposta="ahmet@mail.com", Durum="Aktif" },
            new() { Id = 2, AdSoyadUnvan = "Kalkan Yazılım Ltd.", Telefon="0(312) xxx xx xx", Eposta="info@kalkan.com", Durum="Aktif" },
            new() { Id = 3, AdSoyadUnvan = "Mehmet Demir", Telefon="05xx xxx xx xx", Eposta="mehmet@mail.com", Durum="Pasif" },
        };

    ViewData["Title"] = "Müşteriler";
    return View(liste);
  }

  [HttpGet]
  public IActionResult Yeni()
  {
    ViewData["Title"] = "Yeni Müşteri Ekle";
    return View(new MusteriYeniVM());
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult Yeni(MusteriYeniVM model)
  {
    ViewData["Title"] = "Yeni Müşteri Ekle";

    if (!ModelState.IsValid)
      return View(model);

    // TODO: DB kaydı
    TempData["BasariliMesaj"] = $"Müşteri kaydedildi: {model.AdSoyadUnvan}";
    return RedirectToAction(nameof(Index));
  }
}
