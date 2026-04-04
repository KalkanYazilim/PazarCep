namespace PazarCep.Areas.Egitim.Models;

public class KursIcerikVM
{
  public int Id
  {
    get; set;
  }
  public int KursId
  {
    get; set;
  }
  public string KursAdi { get; set; } = "";
  public string SertifikaNo { get; set; } = "";
  public DateTime Tarih
  {
    get; set;
  }
  public List<DersSatiriVM> Dersler { get; set; } = new();

  public string Durum { get; set; } = ""; // Onaylı / Beklemede
}
