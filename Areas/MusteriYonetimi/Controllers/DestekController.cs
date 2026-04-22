using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class DestekController : Controller
{
  public IActionResult Sikayet()
  {
    ViewData["Title"] = "Sikayet Talepleri";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Yuksek oncelikli musteri geri bildirimleri";

    return View("Kuyruk", MusteriYonetimiWorkspaceFactory.CreateSupportPage(isComplaintQueue: true));
  }

  public IActionResult Destek()
  {
    ViewData["Title"] = "Destek Talepleri";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Destek ve servis kuyrugu";

    return View("Kuyruk", MusteriYonetimiWorkspaceFactory.CreateSupportPage(isComplaintQueue: false));
  }
}
