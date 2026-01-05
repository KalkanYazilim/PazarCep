using Microsoft.AspNetCore.Mvc;
using PazarCep.Areas.Egitim.Models;

namespace PazarCep.Areas.Egitim.Controllers;


[Area("Egitim")]
[Route("[area]/[controller]/[action]")]
public class KursController : Controller
{
  // GET: /Egitim/Kurs/Index
  public IActionResult Index()
  {
    ViewData["Title"] = "Kurslarım";

    ViewData["DemoData"] = true;
    ViewData["DemoDataKaynak"] = "DemoKurslar()";

    var liste = DemoKurslar();
    return View(liste); // Views/Kurs/Index.cshtml  => List<KursListeSatiriVM>
  }

  /*Örnek Veriler için Yazılmış Kod Bloğu*/
  // Menüden id gelmediğinde
  [HttpGet]
  public IActionResult Detay()
  {
  
    return RedirectToAction(nameof(Index));
  }

  /*Örnek Veriler için Yazılmış Kod Bloğu*/
  [HttpGet]
  public IActionResult Icerik()
  {
    
    return RedirectToAction(nameof(Index));
  }

  // GET: /Egitim/Kurs/Detay/1
  [HttpGet("{id:int}")]
  public IActionResult Detay(int id)
  {
    ViewData["Title"] = "Kurs Detayı";

    ViewData["DemoData"] = true;
    ViewData["DemoDataKaynak"] = $"DemoKursDetay({id})";

    var kurs = DemoKursDetay(id);
    if (kurs == null)
      return NotFound();

    return View(kurs); // Views/Kurs/Detay.cshtml => KursDetayVM
  }

  // GET: /Egitim/Kurs/Icerik/1
  [HttpGet("{id:int}")]
  public IActionResult Icerik(int id)
  {
    ViewData["Title"] = "Kurs İçeriği";

    ViewData["DemoData"] = true;
    ViewData["DemoDataKaynak"] = $"DemoKursIcerik({id})";

    var icerik = DemoKursIcerik(id);
    if (icerik == null)
      return NotFound();

    return View(icerik); // Views/Kurs/Icerik.cshtml => KursIcerikVM
  }

  // POST: /Egitim/Kurs/DersTamamla
  // (Şimdilik demo: gerçek hayatta DB update olacak)
  [HttpPost]
  [ValidateAntiForgeryToken]
  public IActionResult DersTamamla(int kursId, int dersId)
  {
    TempData["BasariliMesaj"] = $"Ders tamamlandı (KursId={kursId}, DersId={dersId}).";
    return RedirectToAction(nameof(Icerik), new
    {
      id = kursId
    });
  }

  // GET: /Egitim/Kurs/Sertifikalar
  public IActionResult Sertifikalar()
  {
    ViewData["Title"] = "Sertifikalarım";

    ViewData["DemoData"] = true;
    ViewData["DemoDataKaynak"] = "DemoSertifikalar()";

    var liste = DemoSertifikalar();
    return View(liste); // Views/Kurs/Sertifikalar.cshtml => List<SertifikaSatiriVM>
  }

  // -----------------------
  // DEMO VERİLER (sonra DB)
  // -----------------------

  private static List<KursListeSatiriVM> DemoKurslar()
  {
    return new List<KursListeSatiriVM>
    {
      new()
      {
        Id = 1,
        KursAdi = "Modern Tarım Pazarlaması",
        Seviye = "Orta",
        Egitmen = "Dr. Ayşe Çelik",
        Durum = "Devam Ediyor",
        IlerlemeYuzde = 45,
        SonGuncelleme = DateTime.Today
      },
      new()
      {
        Id = 2,
        KursAdi = "Gıda Lojistiği ve Soğuk Zincir",
        Seviye = "İleri",
        Egitmen = "Müh. Mehmet Aslan",
        Durum = "Beklemede",
        IlerlemeYuzde = 0,
        SonGuncelleme = DateTime.Today.AddDays(-3)
      },
      new()
      {
        Id = 3,
        KursAdi = "Temel E-Ticaret Eğitimi",
        Seviye = "Başlangıç",
        Egitmen = "Kalkan Akademi",
        Durum = "Tamamlandı",
        IlerlemeYuzde = 100,
        SonGuncelleme = DateTime.Today.AddDays(-10)
      }
    };
  }

  private static KursDetayVM? DemoKursDetay(int id)
  {
    var hepsi = DemoKurslar();
    var s = hepsi.FirstOrDefault(x => x.Id == id);
    if (s == null)
      return null;

    return new KursDetayVM
    {
      Id = s.Id,
      KursAdi = s.KursAdi,
      Egitmen = s.Egitmen,
      Seviye = s.Seviye,
      IlerlemeYuzde = s.IlerlemeYuzde,
      SureDakika = id == 1 ? 320 : id == 2 ? 210 : 180,
      Aciklama = "Bu kurs, PazarCep ekosisteminde üretici–alıcı–lojistik süreçlerini destekleyen pratik bilgiler içerir. Bölümler ilerledikçe kontrol listeleri ve mini quizler göreceksiniz.",
      Bolumler = new List<KursBolumSatiriVM>
      {
        new() { Sira = 1, Baslik = "Giriş ve Temel Kavramlar", ToplamDers = 6, TamamlananDers = Math.Min(6, s.IlerlemeYuzde/10) },
        new() { Sira = 2, Baslik = "Uygulamalı Örnekler", ToplamDers = 8, TamamlananDers = Math.Min(8, Math.Max(0, (s.IlerlemeYuzde-20)/10)) },
        new() { Sira = 3, Baslik = "Değerlendirme ve Quiz", ToplamDers = 4, TamamlananDers = s.IlerlemeYuzde >= 90 ? 4 : 0 }
      }
    };
  }

  private static KursIcerikVM? DemoKursIcerik(int id)
  {
    var hepsi = DemoKurslar();
    var s = hepsi.FirstOrDefault(x => x.Id == id);
    if (s == null)
      return null;

    var dersler = new List<DersSatiriVM>
    {
      new() { Id = 1, Baslik = "Kurs Tanıtımı", SureDakika = 8, Tamamlandi = s.IlerlemeYuzde >= 10 },
      new() { Id = 2, Baslik = "Temel Terimler", SureDakika = 14, Tamamlandi = s.IlerlemeYuzde >= 25 },
      new() { Id = 3, Baslik = "Uygulama: Senaryo 1", SureDakika = 22, Tamamlandi = s.IlerlemeYuzde >= 40 },
      new() { Id = 4, Baslik = "Uygulama: Senaryo 2", SureDakika = 26, Tamamlandi = s.IlerlemeYuzde >= 60 },
      new() { Id = 5, Baslik = "Mini Quiz", SureDakika = 10, Tamamlandi = s.IlerlemeYuzde >= 85 },
    };

    return new KursIcerikVM
    {
      KursId = s.Id,
      KursAdi = s.KursAdi,
      Dersler = dersler
    };
  }

  private static List<SertifikaSatiriVM> DemoSertifikalar()
  {
    return new List<SertifikaSatiriVM>
    {
      new() { Id = 1, SertifikaAdi = "Temel E-Ticaret Sertifikası", Kurum = "Kalkan Akademi", Tarih = DateTime.Today.AddDays(-10) },
      new() { Id = 2, SertifikaAdi = "Müşteri İlişkileri Yönetimi (CRM) Sertifikası", Kurum = "PazarCep Eğitim", Tarih = DateTime.Today.AddDays(-35) }
    };
  }
}
