namespace PazarCep.Areas.Egitim.Models;

public class KursKartVM
{
  public int Id
  {
    get; set;
  }
  public string KursAdi { get; set; } = "";
  public string Egitmen { get; set; } = "";
  public string Seviye { get; set; } = "";
  public int SureDakika
  {
    get; set;
  }
  public int IlerlemeYuzde
  {
    get; set;
  }
}
