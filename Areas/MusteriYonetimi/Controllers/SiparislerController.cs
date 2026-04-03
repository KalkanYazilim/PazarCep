using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class SiparislerController : Controller
{
  public IActionResult TumSiparisler()
  {
    ViewData["Title"] = "Tüm Siparişler";

    var liste = new List<SiparisListeSatiriVM>
        {
            new() { Id=101, SiparisNo="SP-2025-000101", Musteri="Ahmet Yılmaz", Tarih=DateTime.Today.AddDays(-2), Tutar=1850, Durum="Hazırlanıyor" },
            new() { Id=102, SiparisNo="SP-2025-000102", Musteri="Kalkan Yazılım Ltd.", Tarih=DateTime.Today.AddDays(-1), Tutar=4200, Durum="Beklemede" },
            new() { Id=103, SiparisNo="SP-2025-000103", Musteri="Mehmet Demir", Tarih=DateTime.Today, Tutar=980, Durum="Tamamlandı" },
        };

    return View(liste);
  }

  public IActionResult Bekleyen()
  {
    ViewData["Title"] = "Bekleyen Siparişler";

    var liste = new List<SiparisListeSatiriVM>
        {
            new() { Id=102, SiparisNo="SP-2025-000102", Musteri="Kalkan Yazılım Ltd.", Tarih=DateTime.Today.AddDays(-1), Tutar=4200, Durum="Beklemede" },
            new() { Id=110, SiparisNo="SP-2025-000110", Musteri="Ahmet Yılmaz", Tarih=DateTime.Today.AddDays(-4), Tutar=650, Durum="Beklemede" },
        };

    return View(liste);
  }
}
