using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.MusteriYonetimi.Models;

public class DestekTalepListeSatiriVM
{
  public int Id
  {
    get; set;
  }

  [Display(Name = "Talep No")]
  public string TalepNo { get; set; } = "";

  [Display(Name = "Konu")]
  public string Konu { get; set; } = "";

  [Display(Name = "Müşteri")]
  public string Musteri { get; set; } = "";

  [Display(Name = "Öncelik")]
  public string Oncelik { get; set; } = "Normal";

  [Display(Name = "Durum")]
  public string Durum { get; set; } = "Açık";

  [Display(Name = "Tarih")]
  public DateTime Tarih
  {
    get; set;
  }
}
