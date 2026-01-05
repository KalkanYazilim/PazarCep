namespace PazarCep.Areas.Egitim.Models;

public class EgitimPanoVM
{
  public int ToplamKurs
  {
    get; set;
  }
  public int DevamEdilenKurs
  {
    get; set;
  }
  public int TamamlananKurs
  {
    get; set;
  }
  public int SertifikaSayisi
  {
    get; set;
  }

  public List<EgitimAktiviteSatiriVM> SonAktiviteler { get; set; } = new();
}
