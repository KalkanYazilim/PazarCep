namespace PazarCep.Areas.Egitim.Models;

public class KursBolumSatiriVM
{
  public int Sira
  {
    get; set;
  }
  public string Baslik { get; set; } = "";
  public int ToplamDers
  {
    get; set;
  }
  public int TamamlananDers
  {
    get; set;
  }
}
