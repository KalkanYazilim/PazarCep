using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class PanelController : Controller
{
  public IActionResult Ciftci() => Dashboard("Farmer");
  public IActionResult Alici() => Dashboard("Buyer");
  public IActionResult Yevmiyeci() => Dashboard("Worker");
  public IActionResult Lojistik() => Dashboard("Logistics");
  public IActionResult Danisman() => Dashboard("Consultant");

  public IActionResult CiftciTarlalar() => Operation("Farmer", "Fields");
  public IActionResult CiftciTarlaIsleri() => Operation("Farmer", "FieldWork");
  public IActionResult CiftciYevmiye() => View("Assignment", BusinessPanelFactory.CreateAssignment("Farmer"));
  public IActionResult CiftciFinans() => Finance("Farmer");

  public IActionResult AliciAlimlar() => Operation("Buyer", "Purchases");
  public IActionResult AliciStok() => Operation("Buyer", "Stock");
  public IActionResult AliciIndirme() => View("Assignment", BusinessPanelFactory.CreateAssignment("Buyer"));
  public IActionResult AliciFinans() => Finance("Buyer");

  public IActionResult YevmiyeciDavetler() => Operation("Worker", "Invitations");
  public IActionResult YevmiyeciTakvim() => Operation("Worker", "Availability");
  public IActionResult YevmiyeciKazanc() => Operation("Worker", "Earnings");

  public IActionResult LojistikAraclar() => Operation("Logistics", "Vehicles");
  public IActionResult LojistikNakliye() => Operation("Logistics", "TransportJobs");
  public IActionResult LojistikFinans() => Finance("Logistics");

  public IActionResult DanismanRandevular() => Operation("Consultant", "Appointments");
  public IActionResult DanismanSaha() => Operation("Consultant", "Reports");
  public IActionResult DanismanFinans() => Finance("Consultant");

  private IActionResult Dashboard(string roleKey)
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Rol bazlı yönetim paneli";
    ViewData["MetaDescription"] = "PazarCep rol bazlı işletme yönetimi paneli.";
    return View("Dashboard", BusinessPanelFactory.CreateDashboard(roleKey));
  }

  private IActionResult Operation(string roleKey, string pageKey)
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Operasyon yönetimi";
    ViewData["MetaDescription"] = "PazarCep rol bazlı operasyon yönetimi ekranı.";
    return View("Operation", BusinessPanelFactory.CreateOperation(roleKey, pageKey));
  }

  private IActionResult Finance(string roleKey)
  {
    ViewData["DemoVeri"] = true;
    ViewData["DemoVeriNotu"] = "Gelir / gider yönetimi";
    ViewData["MetaDescription"] = "PazarCep ortak gelir gider yönetimi ekranı.";
    return View("Finance", BusinessPanelFactory.CreateFinance(roleKey));
  }
}
