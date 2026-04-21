using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.ETicaret.Models;

namespace PazarCep.Areas.ETicaret.Controllers;

[Area("ETicaret")]
public class RandevuController : Controller
{
  public IActionResult Index()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Randevu planlama";
    ViewData["MetaDescription"] = "PazarCep randevu planlama ekranı; yükleme ve teslim alma slotlarını yönetir.";

    return View(CommerceWorkspaceFactory.CreateAppointmentBoard());
  }
}
