using System.ComponentModel.DataAnnotations;

namespace PazarCep.Areas.MusteriYonetimi.Models;

public class NotListeSatiriVM
{
  public int Id
  {
    get; set;
  }

  [Display(Name = "Müşteri")]
  public string Musteri { get; set; } = "";

  [Display(Name = "Başlık")]
  public string Baslik { get; set; } = "";

  [Display(Name = "Not")]
  public string Icerik { get; set; } = "";

  [Display(Name = "Tarih")]
  public DateTime Tarih
  {
    get; set;
  }
}
