using Microsoft.AspNetCore.Mvc;
using PazarCep.Models;

namespace PazarCep.Controllers;

public class AuthController : Controller
{
  public IActionResult ForgotPasswordBasic() => View();
  public IActionResult LoginBasic() => View();

  [HttpGet]
  public IActionResult RegisterBasic() => View(new RegisterBasicViewModel());

  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult RegisterBasic(RegisterBasicViewModel model)
  {
    var selectedRoles = (model.SelectedRoles ?? new List<string>())
      .Where(role => PublicUserRoles.AllowedRoleKeys.Contains(role))
      .Distinct(StringComparer.OrdinalIgnoreCase)
      .ToList();

    if (selectedRoles.Count == 0)
    {
      ModelState.AddModelError(nameof(model.SelectedRoles), "Lütfen PazarCep’i hangi amaçla kullanacağınızı seçin.");
    }

    if (!ModelState.IsValid)
    {
      model.SelectedRoles = selectedRoles;
      return View(model);
    }

    model.SelectedRoles = selectedRoles;

    // TODO: Persist selected public role preferences with approval state when user registration storage is implemented.
    TempData["RegisterRolePreferences"] = string.Join(",", model.SelectedRoles);
    TempData["RegisterSuccessMessage"] = "Hesap oluşturma talebiniz alındı. Seçtiğiniz roller onay sürecine göre değerlendirilecektir.";

    return RedirectToAction(nameof(LoginBasic));
  }
}
