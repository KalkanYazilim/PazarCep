using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class KullaniciYonetimiController : Controller
    {
        /*
        private IKullaniciYonetimiService _KullaniciYonetimiService;
        public KullaniciYonetimiController()
        {
            _KullaniciYonetimiService = new KullaniciYonetimiService(new KullaniciYonetimiRepository());
        
        }*/
        // GET: KullaniciYonetimiController
        public ActionResult Index()
        {
            //var KullaniciYonetimiListesi_Var = _KullaniciYonetimiService.GetAll();
            return View();
        }

        // GET: KullaniciYonetimiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KullaniciYonetimiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KullaniciYonetimiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KullaniciYonetimiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KullaniciYonetimiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KullaniciYonetimiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KullaniciYonetimiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}


