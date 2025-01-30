using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class Ciftci_BilgisiController : Controller
    {
        private ICiftci_BilgisiService _Ciftci_BilgisiService;
        public Ciftci_BilgisiController()
        {
            _Ciftci_BilgisiService = new Ciftci_BilgisiService(new Ciftci_BilgisiRepository());

        }
        // GET: Ciftci_BilgisiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ciftci_BilgisiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ciftci_BilgisiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ciftci_BilgisiController/Create
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

        // GET: Ciftci_BilgisiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ciftci_BilgisiController/Edit/5
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

        // GET: Ciftci_BilgisiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ciftci_BilgisiController/Delete/5
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

