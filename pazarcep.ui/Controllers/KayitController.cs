using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class KayitController : Controller
    {
        /*
        private IKayitService _KayitService;
        public KayitController()
        {
            _KayitService = new KayitService(new KayitRepository());
        
        }*/
        // GET: KayitController
        public ActionResult Index()
        {
            //var KayitListesi_Var = _KayitService.GetAll();
            return View();
        }

        // GET: KayitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KayitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KayitController/Create
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

        // GET: KayitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KayitController/Edit/5
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

        // GET: KayitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KayitController/Delete/5
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


