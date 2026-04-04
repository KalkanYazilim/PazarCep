using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class PuanlarController : Controller
    {
        private IPuanlarService _PuanlarService;
        public PuanlarController()
        {
            _PuanlarService = new PuanlarService(new PuanlarRepository());

        }
        // GET: PuanlarController
        public ActionResult Index()
        {
            var PuanlarListesi_Var = _PuanlarService.GetAll();
            return View(PuanlarListesi_Var);
        }

        // GET: PuanlarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PuanlarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PuanlarController/Create
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

        // GET: PuanlarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PuanlarController/Edit/5
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

        // GET: PuanlarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PuanlarController/Delete/5
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

