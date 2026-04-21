using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PazarCep.Areas.ETicaret.Models;

public sealed class UrunEkleViewModel
{
  [Required(ErrorMessage = "Ürün adı zorunludur.")]
  [StringLength(120)]
  public string UrunAdi { get; set; } = string.Empty;

  [Required(ErrorMessage = "Kategori seçimi zorunludur.")]
  public string Kategori { get; set; } = string.Empty;

  [Required(ErrorMessage = "SKU / Barkod zorunludur.")]
  [StringLength(64)]
  public string StokKodu { get; set; } = string.Empty;

  [Required(ErrorMessage = "Satış fiyatı zorunludur.")]
  [Range(0.01, 999999)]
  public decimal SatisFiyati { get; set; }

  [Range(0, 999999)]
  public decimal? IndirimliFiyat { get; set; }

  [Required(ErrorMessage = "Stok miktarı zorunludur.")]
  [Range(0, 999999)]
  public int StokMiktari { get; set; }

  [Range(0, 999999)]
  public int KritikStokSeviyesi { get; set; } = 10;

  [StringLength(80)]
  public string Birim { get; set; } = "kg";

  [Required(ErrorMessage = "Kısa açıklama zorunludur.")]
  [StringLength(240)]
  public string KisaAciklama { get; set; } = string.Empty;

  [StringLength(3000)]
  public string? Aciklama { get; set; }

  public bool VitrindeGoster { get; set; }
  public bool KargoUygun { get; set; } = true;

  public IReadOnlyList<SelectListItem> KategoriSecenekleri { get; init; } = [];
  public IReadOnlyList<SelectListItem> BirimSecenekleri { get; init; } = [];
}
