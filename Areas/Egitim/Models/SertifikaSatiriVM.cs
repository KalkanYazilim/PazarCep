namespace PazarCep.Areas.Egitim.Models;

public class SertifikaSatiriVM
{
  public int Id
  {
    get; set;
  }
  public string SertifikaAdi { get; set; } = "";
  public string Kurum { get; set; } = "";
  public DateTime Tarih
  {
    get; set;
  }
}
