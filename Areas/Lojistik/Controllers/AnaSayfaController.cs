using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Lojistik.Models;

namespace PazarCep.Areas.Lojistik.Controllers;

[Area("Lojistik")]
[Route("[area]/[controller]/[action]")]
public class AnaSayfaController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Lojistik Operasyon Merkezi";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Canli rota ve filo gorunumu";

    return View(LojistikWorkspaceFactory.CreateOverview());
  }
}
