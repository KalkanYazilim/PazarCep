using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class TablesController : Controller
{
  public IActionResult Basic() => View();
}
