using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class IconsController : Controller
{
  public IActionResult Boxicons() => View();
}
