using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class BildirimController : Controller
    {
        private IBildirimService _BildirimService;
        public BildirimController()
        {
            _BildirimService = new BildirimService(new BildirimRepository());

        }
        // GET: BildirimController
        public ActionResult Index()
        {
            var BildirimListesi_Var = _BildirimService.GetAll();
            return View(BildirimListesi_Var);
        }

        // GET: BildirimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BildirimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BildirimController/Create
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

        // GET: BildirimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BildirimController/Edit/5
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

        // GET: BildirimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BildirimController/Delete/5
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

