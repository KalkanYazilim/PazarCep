using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class ExtendedUiController : Controller
{
  public IActionResult PerfectScrollbar() => View();
  public IActionResult TextDivider() => View();
}
