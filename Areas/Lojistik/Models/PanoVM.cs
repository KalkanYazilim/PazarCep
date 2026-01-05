namespace PazarCep.Areas.Lojistik.Models;

public class LojistikPanoVM
{
  public int ToplamArac
  {
    get; set;
  }
  public int MusaitArac
  {
    get; set;
  }
  public int SevkiyattaArac
  {
    get; set;
  }
  public int ServisteArac
  {
    get; set;
  }

  public int BugunkuSevkiyat
  {
    get; set;
  }
  public int BekleyenSevkiyat
  {
    get; set;
  }

  public List<SevkiyatListeSatiriVM> SonSevkiyatlar { get; set; } = new();
}
