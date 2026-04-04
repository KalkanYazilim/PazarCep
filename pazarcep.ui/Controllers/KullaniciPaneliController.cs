using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class KullaniciPaneliController : Controller
    {
        /*
        private IKullaniciPaneliService _KullaniciPaneliService;
        public KullaniciPaneliController()
        {
            _KullaniciPaneliService = new KullaniciPaneliService(new KullaniciPaneliRepository());
        
        }*/
        // GET: KullaniciPaneliController
        public ActionResult Index()
        {
            //var KullaniciPaneliListesi_Var = _KullaniciPaneliService.GetAll();
            return View();
        }

        // GET: KullaniciPaneliController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KullaniciPaneliController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KullaniciPaneliController/Create
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

        // GET: KullaniciPaneliController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KullaniciPaneliController/Edit/5
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

        // GET: KullaniciPaneliController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KullaniciPaneliController/Delete/5
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


