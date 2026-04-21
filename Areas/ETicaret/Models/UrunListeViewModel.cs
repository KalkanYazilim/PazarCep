namespace PazarCep.Areas.ETicaret.Models;

public sealed class UrunListeViewModel
{
  public int ToplamUrun { get; init; }
  public int AktifUrun { get; init; }
  public int KritikStokUrun { get; init; }
  public decimal OrtalamaSepetTutari { get; init; }
  public IReadOnlyList<UrunKartViewModel> Urunler { get; init; } = [];
}
