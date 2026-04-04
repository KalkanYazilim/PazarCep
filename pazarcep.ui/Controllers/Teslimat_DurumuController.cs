using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class Teslimat_DurumuController : Controller
    {
        private ITeslimat_DurumuService _Teslimat_DurumuService;
        public Teslimat_DurumuController()
        {
            _Teslimat_DurumuService = new Teslimat_DurumuService(new Teslimat_DurumuRepository());

        }
        // GET: Teslimat_DurumuController
        public ActionResult Index()
        {
            var Teslimat_DurumuListesi_Var = _Teslimat_DurumuService.GetAll();
            return View(Teslimat_DurumuListesi_Var);
        }

        // GET: Teslimat_DurumuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Teslimat_DurumuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teslimat_DurumuController/Create
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

        // GET: Teslimat_DurumuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Teslimat_DurumuController/Edit/5
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

        // GET: Teslimat_DurumuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Teslimat_DurumuController/Delete/5
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

