using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.ETicaret.Models;

namespace PazarCep.Areas.ETicaret.Controllers;

[Area("ETicaret")]
public class AnaSayfaController : Controller
{
  public IActionResult Index()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Ticari görünüm";
    ViewData["MetaDescription"] = "PazarCep e-ticaret operasyon özeti; katalog, sipariş ve randevu akışlarını tek panelde toplar.";

    return View(CommerceWorkspaceFactory.CreateOverview());
  }
}
