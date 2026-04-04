using Microsoft.AspNetCore.Mvc;

namespace PazarCep.Areas.ETicaret.Controllers
{
  [Area("ETicaret")]
  public class UrunlerController : Controller
  {
    public IActionResult Liste() => View();
    public IActionResult Ekle() => View();
    public IActionResult Kategoriler() => View();
  }
}
