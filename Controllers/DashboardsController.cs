using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Operasyon özeti";
    ViewData["MetaDescription"] = "PazarCep kontrol merkezi; e-ticaret, lojistik ve CRM akışlarını tek panelde özetler.";

    return View(AdminDashboardFactory.Create());
  }
}
