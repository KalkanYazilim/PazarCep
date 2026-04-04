using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class IletisimNotlarController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "İletişim & Notlar";

    var liste = new List<NotListeSatiriVM>
        {
            new() { Id=1, Musteri="Ahmet Yılmaz", Baslik="Teslimat bilgisi", Icerik="Adres teyidi alındı.", Tarih=DateTime.Today.AddDays(-3) },
            new() { Id=2, Musteri="Kalkan Yazılım Ltd.", Baslik="Fatura talebi", Icerik="E-fatura bilgileri güncellendi.", Tarih=DateTime.Today.AddDays(-1) },
        };

    return View(liste);
  }
}
