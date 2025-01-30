using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class UrunController : Controller
    {
        private IUrunService _UrunService;
        public UrunController()
        {
            _UrunService = new UrunService(new UrunRepository());

        }
        // GET: UrunController
        public ActionResult Index()
        {
            var UrunListesi_Var = _UrunService.GetAll();
            return View(UrunListesi_Var);
        }

        // GET: UrunController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunController/Create
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

        // GET: UrunController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunController/Edit/5
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

        // GET: UrunController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunController/Delete/5
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

