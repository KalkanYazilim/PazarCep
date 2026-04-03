using Microsoft.AspNetCore.Mvc;

namespace PazarCep.Areas.ETicaret.Controllers
{
  [Area("ETicaret")]
  public class EmirController : Controller
  {
    public IActionResult SiparisListesi() => View();

    // örnek: /ETicaret/Emir/SiparisDetay/5
    public IActionResult SiparisDetay(int? id)
    {
      ViewBag.SiparisId = id;
      return View();
    }
  }
}
