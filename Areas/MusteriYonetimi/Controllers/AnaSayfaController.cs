using Microsoft.AspNetCore.Mvc;

namespace PazarCep.Areas.MusteriYonetimi.Controllers
{
  [Area("MusteriYonetimi")]
  public class AnaSayfaController : Controller
  {
    public IActionResult Index() => View();
  }
}
