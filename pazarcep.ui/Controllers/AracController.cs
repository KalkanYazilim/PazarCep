using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AracController : Controller
    {
        private IAracService _AracService;
        public AracController()
        {
            _AracService = new AracService(new AracRepository());

        }
        // GET: AracController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AracController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AracController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AracController/Create
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

        // GET: AracController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AracController/Edit/5
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

        // GET: AracController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AracController/Delete/5
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

