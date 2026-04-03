using Microsoft.AspNetCore.Mvc;

namespace PazarCep.Areas.ETicaret.Controllers
{
  [Area("ETicaret")]
  public class AnaSayfaController : Controller
  {
    public IActionResult Index() => View();
  }
}
