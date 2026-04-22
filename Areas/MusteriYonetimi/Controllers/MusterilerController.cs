using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class MusterilerController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Musteriler";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "CRM portfoy listesi";

    return View(MusteriYonetimiWorkspaceFactory.CreateCustomerList());
  }

  [HttpGet]
  public IActionResult Yeni()
  {
    ViewData["Title"] = "Yeni Musteri";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Onboarding formu";

    return View(MusteriYonetimiWorkspaceFactory.CreateCustomerForm());
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult Yeni(MusteriKayitFormViewModel model)
  {
    ViewData["Title"] = "Yeni Musteri";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Onboarding formu";

    if (!ModelState.IsValid)
    {
      return View(model);
    }

    TempData["BasariliMesaj"] = $"{model.AdSoyadUnvan} icin musteri kaydi taslagi olusturuldu.";
    return RedirectToAction(nameof(Index));
  }
}
