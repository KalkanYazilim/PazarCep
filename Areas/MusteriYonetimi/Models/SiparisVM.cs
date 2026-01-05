using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.MusteriYonetimi.Models;

public class SiparisListeSatiriVM
{
  public int Id
  {
    get; set;
  }

  [Display(Name = "Sipariş No")]
  public string SiparisNo { get; set; } = "";

  [Display(Name = "Müşteri")]
  public string Musteri { get; set; } = "";

  [Display(Name = "Tarih")]
  public DateTime Tarih
  {
    get; set;
  }

  [Display(Name = "Tutar")]
  public decimal Tutar
  {
    get; set;
  }

  [Display(Name = "Durum")]
  public string Durum { get; set; } = "";
}
