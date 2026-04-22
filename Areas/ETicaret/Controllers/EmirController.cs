using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.ETicaret.Models;

namespace PazarCep.Areas.ETicaret.Controllers;

[Area("ETicaret")]
public class EmirController : Controller
{
  public IActionResult SiparisListesi()
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Sipariş simülasyonu";
    return View(CommerceWorkspaceFactory.CreateOrderList());
  }

  public IActionResult SiparisDetay(int? id)
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Sipariş detayı";
    return View(CommerceWorkspaceFactory.CreateOrderDetail(id));
  }
}
