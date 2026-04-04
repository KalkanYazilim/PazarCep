namespace PazarCep.Areas.Egitim.Models;

public class KursListeSatiriVM
{
  public int Id
  {
    get; set;
  }
  public string KursAdi { get; set; } = "";
  public string Seviye { get; set; } = "";
  public string Egitmen { get; set; } = "";
  public string Durum { get; set; } = "";  // Devam Ediyor / Tamamlandı / Beklemede
  public int IlerlemeYuzde
  {
    get; set;
  }
  public DateTime SonGuncelleme
  {
    get; set;
  }
}
