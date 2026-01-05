using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Lojistik.Models;

namespace PazarCep.Areas.Lojistik.Controllers;

[Area("Lojistik")]
[Route("[area]/[controller]/[action]")]
public class FiloController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Filo Yönetimi";

    // TODO: DB/Servis katmanı eklendiğinde bu liste oradan gelecek.
    var liste = DemoAracListesi();

    return View(liste);
  }

  public IActionResult AracDetay(int id)
  {
    ViewData["Title"] = "Araç Detayı";

    // TODO: DB/Servis katmanı eklendiğinde kayıt oradan gelecek.
    var vm = DemoAracDetay(id);

    if (vm is null)
      return NotFound(); // Profesyonel davranış: id yoksa 404

    return View(vm);
  }

  private static List<AracListeSatiriVM> DemoAracListesi()
  {
    return new List<AracListeSatiriVM>
        {
            new()
            {
                Id = 1, Plaka = "51 ABC 123", AracTipi = "Kamyonet", Surucu = "Ali Kaya",
                Durum = "Sevkiyatta", Konum = "Niğde → Ankara"
            },
            new()
            {
                Id = 2, Plaka = "06 KLM 456", AracTipi = "Kamyon", Surucu = "Mehmet Aslan",
                Durum = "Müsait", Konum = "Ankara"
            },
            new()
            {
                Id = 3, Plaka = "34 XYZ 789", AracTipi = "Tır", Surucu = "Hasan Demir",
                Durum = "Serviste", Konum = "İstanbul / Sanayi"
            },
        };
  }

  private static AracDetayVM? DemoAracDetay(int id)
  {
    var liste = DemoAracListesi();
    var arac = liste.FirstOrDefault(x => x.Id == id);

    if (arac is null)
      return null;

    // Basit metrikler: demo
    var bugunkuSevkiyatAdedi = id == 2 ? 0 : 2;
    var bugunkuKm = id == 1 ? 210 : id == 3 ? 0 : 35;

    return new AracDetayVM
    {
      Id = arac.Id,
      Plaka = arac.Plaka,
      AracTipi = arac.AracTipi,
      Surucu = arac.Surucu,
      Durum = arac.Durum,
      Konum = arac.Konum,
      SonGuncelleme = DateTime.Now,
      BugunkuSevkiyatAdedi = bugunkuSevkiyatAdedi,
      BugunkuKm = bugunkuKm
    };
  }
}
