using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class SonSaticiController : Controller
    {
        private ISonSaticiService _SonSaticiService;
        public SonSaticiController()
        {
            _SonSaticiService = new SonSaticiService(new SonSaticiRepository());

        }
        // GET: SonSaticiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SonSaticiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SonSaticiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SonSaticiController/Create
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

        // GET: SonSaticiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SonSaticiController/Edit/5
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

        // GET: SonSaticiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SonSaticiController/Delete/5
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

