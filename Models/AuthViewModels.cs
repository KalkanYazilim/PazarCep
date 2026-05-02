using System.ComponentModel.DataAnnotations;

namespace PazarCep.Models;

public static class PublicUserRoles
{
  public static readonly IReadOnlySet<string> AllowedRoleKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
  {
    Buyer,
    Farmer,
    Worker,
    Logistician,
    Consultant
  };

  public const string Buyer = "Buyer";
  public const string Farmer = "Farmer";
  public const string Worker = "Worker";
  public const string Logistician = "Logistician";
  public const string Consultant = "Consultant";
}

public class RegisterBasicViewModel
{
  [Display(Name = "Ad Soyad")]
  public string? FullName { get; set; }

  [Display(Name = "Telefon")]
  public string? Phone { get; set; }

  [Display(Name = "E-posta")]
  public string? Email { get; set; }

  [Display(Name = "Şifre")]
  public string? Password { get; set; }

  [Display(Name = "Şifre Tekrar")]
  public string? ConfirmPassword { get; set; }

  public List<string> SelectedRoles { get; set; } = new();
}
