using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class AnaSayfaController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "CRM Operasyonlari";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Musteri portfoyu ve servis akislari";

    return View(MusteriYonetimiWorkspaceFactory.CreateOverview());
  }
}
