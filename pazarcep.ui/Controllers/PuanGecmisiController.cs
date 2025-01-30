using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class PuanGecmisiController : Controller
    {
        private IPuanGecmisiService _PuanGecmisiService;
        public PuanGecmisiController()
        {
            _PuanGecmisiService = new PuanGecmisiService(new PuanGecmisiRepository());

        }
        // GET: PuanGecmisiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PuanGecmisiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PuanGecmisiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PuanGecmisiController/Create
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

        // GET: PuanGecmisiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PuanGecmisiController/Edit/5
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

        // GET: PuanGecmisiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PuanGecmisiController/Delete/5
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

