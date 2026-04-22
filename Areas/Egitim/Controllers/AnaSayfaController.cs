using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Egitim.Models;

namespace PazarCep.Areas.Egitim.Controllers;

[Area("Egitim")]
[Route("[area]/[controller]/[action]")]
public class AnaSayfaController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Eğitim Merkezi";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Kurs panosu ve öğrenme akışı";

    return View(EgitimWorkspaceFactory.CreateOverview());
  }
}
