using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class DestekController : Controller
{
  public IActionResult Sikayet()
  {
    ViewData["Title"] = "Şikayet Talepleri";

    var liste = new List<DestekTalepListeSatiriVM>
        {
            new() { Id=1, TalepNo="SKY-0001", Konu="Geciken teslimat", Musteri="Ahmet Yılmaz", Oncelik="Yüksek", Durum="Açık", Tarih=DateTime.Today.AddDays(-2) },
            new() { Id=2, TalepNo="SKY-0002", Konu="Eksik ürün", Musteri="Mehmet Demir", Oncelik="Normal", Durum="İnceleniyor", Tarih=DateTime.Today.AddDays(-1) },
        };

    return View(liste);
  }

  public IActionResult Destek()
  {
    ViewData["Title"] = "Destek Talepleri";

    var liste = new List<DestekTalepListeSatiriVM>
        {
            new() { Id=10, TalepNo="DST-0010", Konu="Şifre sıfırlama", Musteri="Kalkan Yazılım Ltd.", Oncelik="Normal", Durum="Çözüldü", Tarih=DateTime.Today.AddDays(-5) },
            new() { Id=11, TalepNo="DST-0011", Konu="Panelde hata", Musteri="Ahmet Yılmaz", Oncelik="Yüksek", Durum="Açık", Tarih=DateTime.Today.AddDays(-1) },
        };

    return View(liste);
  }
}
