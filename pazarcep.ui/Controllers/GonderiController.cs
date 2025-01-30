using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class GonderiController : Controller
    {
        private IGonderiService _GonderiService;
        public GonderiController()
        {
            _GonderiService = new GonderiService(new GonderiRepository());

        }
        // GET: GonderiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GonderiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GonderiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GonderiController/Create
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

        // GET: GonderiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GonderiController/Edit/5
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

        // GET: GonderiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GonderiController/Delete/5
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

