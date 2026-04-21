using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.ETicaret.Models;

namespace PazarCep.Areas.ETicaret.Controllers;

[Area("ETicaret")]
public class MusteriController : Controller
{
  public IActionResult TumMusteriler()
  {
    return View(MusteriWorkspaceFactory.CreateDizinPage());
  }

  public IActionResult GenelBakis(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateGenelBakisPage(id));
  }

  public IActionResult Bilgiler(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateBilgilerPage(id));
  }

  public IActionResult AdresFaturalandirma(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateAdresFaturalandirmaPage(id));
  }

  public IActionResult Bildirimler(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateBildirimlerPage(id));
  }

  public IActionResult YorumYonetimi(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateYorumYonetimiPage(id));
  }

  public IActionResult Yonlendirmeler(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateYonlendirmelerPage(id));
  }

  public IActionResult Guvenlik(int? id)
  {
    return View(MusteriWorkspaceFactory.CreateGuvenlikPage(id));
  }
}
