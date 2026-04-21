using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Lojistik.Models;

namespace PazarCep.Areas.Lojistik.Controllers;

[Area("Lojistik")]
[Route("[area]/[controller]/[action]")]
public class FiloController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Filo Yonetimi";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Arac durumu ve saha kullanimi";

    return View(LojistikWorkspaceFactory.CreateFleetPage());
  }

  public IActionResult AracDetay(int id)
  {
    ViewData["Title"] = "Arac Detayi";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Arac bazli operasyon gorunumu";

    var vm = LojistikWorkspaceFactory.CreateVehicleDetailPage(id);

    if (vm is null)
    {
      return NotFound();
    }

    return View(vm);
  }
}
