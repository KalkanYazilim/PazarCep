using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.MusteriYonetimi.Models;

namespace PazarCep.Areas.MusteriYonetimi.Controllers;

[Area("MusteriYonetimi")]
[Route("[area]/[controller]/[action]")]
public class IletisimNotlarController : Controller
{
  public IActionResult Index()
  {
    ViewData["Title"] = "Iletisim ve Notlar";
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Temsilci notlari ve temas plani";

    return View(MusteriYonetimiWorkspaceFactory.CreateNotesPage());
  }
}
