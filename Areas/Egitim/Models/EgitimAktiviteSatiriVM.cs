namespace PazarCep.Areas.Egitim.Models;

public class EgitimAktiviteSatiriVM
{
  public DateTime Tarih
  {
    get; set;
  }
  public string Baslik { get; set; } = "";
  public string Aciklama { get; set; } = "";
}
