using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Lojistik.Models;

namespace PazarCep.Areas.Lojistik.Controllers;

[Area("Lojistik")]
[Route("[area]/[controller]/[action]")]
public class AnaSayfaController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Lojistik - Kontrol Paneli";

    // TODO: DB/Servis katmanı eklendiğinde bu veri oradan gelecek.
    var vm = DemoVeriOlustur();

    return View(vm);
  }

  private static LojistikPanoVM DemoVeriOlustur()
  {
    var bugun = DateTime.Today;

    return new LojistikPanoVM
    {
      ToplamArac = 12,
      MusaitArac = 6,
      SevkiyattaArac = 4,
      ServisteArac = 2,
      BugunkuSevkiyat = 9,
      BekleyenSevkiyat = 3,
      SonSevkiyatlar = new List<SevkiyatListeSatiriVM>
            {
                new()
                {
                    Id = 1, SevkiyatNo = "SVK-2025-001", Cikis = "Niğde", Varis = "Ankara",
                    AracPlaka = "51 ABC 123", Durum = "Yolda", Tarih = bugun
                },
                new()
                {
                    Id = 2, SevkiyatNo = "SVK-2025-002", Cikis = "Aksaray", Varis = "Konya",
                    AracPlaka = "06 KLM 456", Durum = "Planlandı", Tarih = bugun
                },
                new()
                {
                    Id = 3, SevkiyatNo = "SVK-2025-003", Cikis = "Ankara", Varis = "İstanbul",
                    AracPlaka = "34 XYZ 789", Durum = "Teslim Edildi", Tarih = bugun.AddDays(-1)
                },
            }
    };
  }
}
