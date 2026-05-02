using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.ETicaret.Models;

namespace PazarCep.Areas.ETicaret.Controllers;

[Area("ETicaret")]
public class RandevuController : Controller
{
  public IActionResult Index() => Takvim();

  public IActionResult Takvim(DateTime? ay = null, DateTime? gun = null)
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Randevu takvimi";
    ViewData["MetaDescription"] = "PazarCep randevu takvimi; teslimat, görüşme, nakliye, danışmanlık ve iş planlarını tek takvimde yönetir.";

    return View("Index", CommerceWorkspaceFactory.CreateAppointmentCalendar(ay, gun));
  }
}
