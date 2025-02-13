using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AkisSayfasiController : Controller
    {
        /*
        private IAkisSayfasiService _AkisSayfasiService;
        public AkisSayfasiController()
        {
            _AkisSayfasiService = new AkisSayfasiService(new AkisSayfasiRepository());
        
        }*/
        // GET: AkisSayfasiController
        public ActionResult Index()
        {
            //var AkisSayfasiListesi_Var = _AkisSayfasiService.GetAll();
            return View();
        }

        // GET: AkisSayfasiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AkisSayfasiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AkisSayfasiController/Create
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

        // GET: AkisSayfasiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AkisSayfasiController/Edit/5
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

        // GET: AkisSayfasiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AkisSayfasiController/Delete/5
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


