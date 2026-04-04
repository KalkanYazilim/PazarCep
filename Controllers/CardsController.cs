using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class CardsController : Controller
{
  public IActionResult Basic() => View();
}
