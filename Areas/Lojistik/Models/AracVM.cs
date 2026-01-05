using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.Lojistik.Models;

public class AracListeSatiriVM
{
  public int Id
  {
    get; set;
  }

  [Display(Name = "Plaka")]
  public string Plaka { get; set; } = "";

  [Display(Name = "Araç Tipi")]
  public string AracTipi { get; set; } = "Kamyonet";

  [Display(Name = "Sürücü")]
  public string Surucu { get; set; } = "";

  [Display(Name = "Durum")]
  public string Durum { get; set; } = "Müsait"; // Müsait / Sevkiyatta / Serviste

  [Display(Name = "Konum")]
  public string? Konum
  {
    get; set;
  }
}

public class AracDetayVM
{
  public int Id
  {
    get; set;
  }
  public string Plaka { get; set; } = "";
  public string AracTipi { get; set; } = "";
  public string Surucu { get; set; } = "";
  public string Durum { get; set; } = "";
  public string? Konum
  {
    get; set;
  }

  public DateTime SonGuncelleme { get; set; } = DateTime.Now;

  // Basit metrikler
  public int BugunkuSevkiyatAdedi
  {
    get; set;
  }
  public decimal BugunkuKm
  {
    get; set;
  }
}
