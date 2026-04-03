using Microsoft.AspNetCore.Mvc;

namespace PazarCep.Areas.ETicaret.Controllers
{
  [Area("ETicaret")]
  public class MusteriController : Controller
  {
    public IActionResult TumMusteriler() => View();

    // “Müşteri Bilgileri” altındaki sekmeler:
    public IActionResult GenelBakis(int? id)
    {
      ViewBag.MusteriId = id;
      return View();
    }
    public IActionResult Guvenlik(int? id)
    {
      ViewBag.MusteriId = id;
      return View();
    }
    public IActionResult AdresFaturalandirma(int? id)
    {
      ViewBag.MusteriId = id;
      return View();
    }
    public IActionResult Bildirimler(int? id)
    {
      ViewBag.MusteriId = id;
      return View();
    }
  }
}
