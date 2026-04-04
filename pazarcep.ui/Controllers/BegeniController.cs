using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class BegeniController : Controller
    {
        private IBegeniService _BegeniService;
        public BegeniController()
        {
            _BegeniService = new BegeniService(new BegeniRepository());

        }
        // GET: BegeniController
        public ActionResult Index()
        {
            var BegeniListesi_Var = _BegeniService.GetAll();
            return View(BegeniListesi_Var);
        }

        // GET: BegeniController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BegeniController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BegeniController/Create
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

        // GET: BegeniController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BegeniController/Edit/5
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

        // GET: BegeniController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BegeniController/Delete/5
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

