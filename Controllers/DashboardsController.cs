using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class DashboardsController : Controller
{
  public IActionResult Index() => View();
}
