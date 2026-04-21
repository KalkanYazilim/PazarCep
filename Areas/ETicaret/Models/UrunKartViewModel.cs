namespace PazarCep.Areas.ETicaret.Models;

public sealed class UrunKartViewModel
{
  public int Id { get; init; }
  public string UrunAdi { get; init; } = string.Empty;
  public string Kategori { get; init; } = string.Empty;
  public string Marka { get; init; } = string.Empty;
  public decimal Fiyat { get; init; }
  public string Birim { get; init; } = string.Empty;
  public int StokMiktari { get; init; }
  public string Durum { get; init; } = string.Empty;
  public double Puan { get; init; }
  public int SiparisAdedi { get; init; }
  public DateTime GuncellenmeTarihi { get; init; }
}
