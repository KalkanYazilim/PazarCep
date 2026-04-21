using Microsoft.AspNetCore.Mvc;

namespace pazarcep.ui.Controllers
{
    public class KayitController : Controller
    {
        // GET: Kayit
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: Kayit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string adSoyad, string eposta, string sifre, string sifreTekrar)
        {
            if (string.IsNullOrWhiteSpace(adSoyad) ||
                string.IsNullOrWhiteSpace(eposta) ||
                string.IsNullOrWhiteSpace(sifre) ||
                string.IsNullOrWhiteSpace(sifreTekrar))
            {
                ViewBag.HataMesaji = "Lütfen tüm alanları doldurun.";
                return View();
            }

            if (!string.Equals(sifre, sifreTekrar, StringComparison.Ordinal))
            {
                ViewBag.HataMesaji = "Şifre ve şifre tekrarı aynı olmalıdır.";
                return View();
            }

            TempData["BasariMesaji"] = "Kayıt işlemi tamamlandı. Şimdi giriş yapabilirsiniz.";
            return RedirectToAction("Index", "Giris");
        }
    }
}
