using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class GonderiHashtagiController : Controller
    {
        private IGonderiHashtagiService _GonderiHashtagiService;
        public GonderiHashtagiController()
        {
            _GonderiHashtagiService = new GonderiHashtagiService(new GonderiHashtagiRepository());

        }
        // GET: GonderiHashtagiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GonderiHashtagiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GonderiHashtagiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GonderiHashtagiController/Create
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

        // GET: GonderiHashtagiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GonderiHashtagiController/Edit/5
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

        // GET: GonderiHashtagiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GonderiHashtagiController/Delete/5
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

