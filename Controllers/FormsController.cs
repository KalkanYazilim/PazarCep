using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class FormsController : Controller
{
  public IActionResult BasicInputs() => View();
  public IActionResult InputGroups() => View();
}
