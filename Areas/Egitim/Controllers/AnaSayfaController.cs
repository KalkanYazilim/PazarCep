using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Egitim.Models;

namespace PazarCep.Areas.Egitim.Controllers;

[Area("Egitim")]
[Route("[area]/[controller]/[action]")]
public class AnaSayfaController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Eğitim - Kontrol Paneli";

    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "EgitimPanoVM (Demo)";

    var vm = new EgitimPanoVM
    {
      ToplamKurs = 8,
      DevamEdilenKurs = 3,
      TamamlananKurs = 2,
      SertifikaSayisi = 2,
      SonAktiviteler = new List<EgitimAktiviteSatiriVM>
      {
        new() { Tarih = DateTime.Today, Baslik = "Kurs izlendi", Aciklama = "Modern Tarım Pazarlaması - Bölüm 2" },
        new() { Tarih = DateTime.Today.AddDays(-1), Baslik = "Sınav tamamlandı", Aciklama = "Gıda Lojistiği - Quiz 1" },
        new() { Tarih = DateTime.Today.AddDays(-2), Baslik = "Sertifika alındı", Aciklama = "Temel E-Ticaret Eğitimi" },
      }
    };

    return View(vm);
  }
}
