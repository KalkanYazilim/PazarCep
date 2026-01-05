using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.MusteriYonetimi.Models;

public class MusteriListeSatiriVM
{
  public int Id
  {
    get; set;
  }

  [Display(Name = "Ad Soyad / Ünvan")]
  public string AdSoyadUnvan { get; set; } = "";

  [Display(Name = "Telefon")]
  public string Telefon { get; set; } = "";

  [Display(Name = "E-posta")]
  public string Eposta { get; set; } = "";

  [Display(Name = "Durum")]
  public string Durum { get; set; } = "Aktif";
}

public class MusteriYeniVM
{
  [Required, StringLength(120)]
  [Display(Name = "Ad Soyad / Ünvan")]
  public string AdSoyadUnvan { get; set; } = "";

  [Required, StringLength(30)]
  [Display(Name = "Telefon")]
  public string Telefon { get; set; } = "";

  [EmailAddress, StringLength(120)]
  [Display(Name = "E-posta")]
  public string? Eposta
  {
    get; set;
  }

  [StringLength(250)]
  [Display(Name = "Adres")]
  public string? Adres
  {
    get; set;
  }

  [Display(Name = "Durum")]
  public bool AktifMi { get; set; } = true;
}
