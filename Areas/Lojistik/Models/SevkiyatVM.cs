using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.Lojistik.Models;

public class SevkiyatListeSatiriVM
{
  public int Id
  {
    get; set;
  }

  [Display(Name = "Sevkiyat No")]
  public string SevkiyatNo { get; set; } = "";

  [Display(Name = "Çıkış")]
  public string Cikis { get; set; } = "";

  [Display(Name = "Varış")]
  public string Varis { get; set; } = "";

  [Display(Name = "Araç")]
  public string AracPlaka { get; set; } = "";

  [Display(Name = "Durum")]
  public string Durum { get; set; } = "Planlandı"; // Planlandı / Yolda / Teslim Edildi

  [Display(Name = "Tarih")]
  public DateTime Tarih
  {
    get; set;
  }
}
