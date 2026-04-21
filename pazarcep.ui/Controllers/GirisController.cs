using Microsoft.AspNetCore.Mvc;

namespace pazarcep.ui.Controllers
{
    public class GirisController : Controller
    {
        // GET: Giris
        [HttpGet]
        public IActionResult Index(string? returnUrl = null)
        {
            if (!string.IsNullOrWhiteSpace(HttpContext.Session.GetString("KullaniciAdi")))
            {
                return RedirectToAction("Index", "AnaSayfa");
            }

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: Giris
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(string eposta, string sifre, string? returnUrl = null)
        {
            if (string.IsNullOrWhiteSpace(eposta) || string.IsNullOrWhiteSpace(sifre))
            {
                ViewBag.HataMesaji = "E-posta ve şifre alanları zorunludur.";
                ViewBag.ReturnUrl = returnUrl;
                return View();
            }

            HttpContext.Session.SetString("KullaniciAdi", eposta.Trim());
            TempData["BasariMesaji"] = "Başarıyla giriş yaptınız.";

            if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "AnaSayfa");
        }

        // POST: Giris/OturumKapat
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult OturumKapat()
        {
            HttpContext.Session.Remove("KullaniciAdi");
            TempData["BasariMesaji"] = "Oturumunuz kapatıldı.";
            return RedirectToAction(nameof(Index));
        }
    }
}
