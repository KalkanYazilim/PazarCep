namespace PazarCep.Areas.Egitim.Models;

public class DersSatiriVM
{
  public int Id
  {
    get; set;
  }
  public string Baslik { get; set; } = "";
  public int SureDakika
  {
    get; set;
  }
  public bool Tamamlandi
  {
    get; set;
  }
}
