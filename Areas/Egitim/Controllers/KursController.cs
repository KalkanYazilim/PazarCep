using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Egitim.Models;

namespace PazarCep.Areas.Egitim.Controllers;

[Area("Egitim")]
[Route("[area]/[controller]/[action]")]
public class KursController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Kurslarım";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Kurs kataloğu ve öğrenme kuyruğu";

    return View(EgitimWorkspaceFactory.CreateCourseListPage());
  }

  [HttpGet]
  public IActionResult Detay()
  {
    return RedirectToAction(nameof(Index));
  }

  [HttpGet]
  public IActionResult Icerik()
  {
    return RedirectToAction(nameof(Index));
  }

  [HttpGet("{id:int}")]
  public IActionResult Detay(int id)
  {
    ViewData["Title"] = "Kurs Detayı";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Kurs özet görünümü";

    var model = EgitimWorkspaceFactory.CreateCourseDetailPage(id);
    if (model is null)
    {
      return NotFound();
    }

    return View(model);
  }

  [HttpGet("{id:int}")]
  public IActionResult Icerik(int id)
  {
    ViewData["Title"] = "Kurs İçeriği";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Ders listesi ve tamamlama akışı";

    var model = EgitimWorkspaceFactory.CreateCourseContentPage(id);
    if (model is null)
    {
      return NotFound();
    }

    return View(model);
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult DersTamamla(int kursId, int dersId)
  {
    TempData["BasariliMesaj"] = $"Ders tamamlandı: ders #{dersId} için ilerleme kaydı taslak olarak işlendi.";
    return RedirectToAction(nameof(Icerik), new { id = kursId });
  }

  public IActionResult Sertifikalar()
  {
    ViewData["Title"] = "Sertifikalarım";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Tamamlanan eğitim çıktıları";

    return View(EgitimWorkspaceFactory.CreateCertificatesPage());
  }
}
