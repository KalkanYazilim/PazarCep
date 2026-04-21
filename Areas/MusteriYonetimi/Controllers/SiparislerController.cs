using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class SiparislerController : Controller
{
  public IActionResult TumSiparisler()
  {
    ViewData["Title"] = "Tum Siparisler";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "CRM siparis kuyrugu";

    return View("Liste", MusteriYonetimiWorkspaceFactory.CreateOrdersPage(onlyPending: false));
  }

  public IActionResult Bekleyen()
  {
    ViewData["Title"] = "Bekleyen Siparisler";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Oncelikli operasyon kuyrugu";

    return View("Liste", MusteriYonetimiWorkspaceFactory.CreateOrdersPage(onlyPending: true));
  }
}
