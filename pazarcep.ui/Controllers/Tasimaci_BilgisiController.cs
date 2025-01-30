using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class Tasimaci_BilgisiController : Controller
    {
        private ITasimaci_BilgisiService _Tasimaci_BilgisiService;
        public Tasimaci_BilgisiController()
        {
            _Tasimaci_BilgisiService = new Tasimaci_BilgisiService(new Tasimaci_BilgisiRepository());

        }
        // GET: Tasimaci_BilgisiController
        public ActionResult Index()
        {
            var Tasimaci_BilgisiListesi_Var = _Tasimaci_BilgisiService.GetAll();
            return View(Tasimaci_BilgisiListesi_Var);
        }

        // GET: Tasimaci_BilgisiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tasimaci_BilgisiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasimaci_BilgisiController/Create
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

        // GET: Tasimaci_BilgisiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tasimaci_BilgisiController/Edit/5
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

        // GET: Tasimaci_BilgisiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tasimaci_BilgisiController/Delete/5
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

