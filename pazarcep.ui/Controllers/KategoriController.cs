using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class KategoriController : Controller
    {
        private IKategoriService _KategoriService;
        public KategoriController()
        {
            _KategoriService = new KategoriService(new KategoriRepository());

        }
        // GET: KategoriController
        public ActionResult Index()
        {
            var KategoriListesi_Var = _KategoriService.GetAll();
            return View(KategoriListesi_Var);
        }

        // GET: KategoriController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KategoriController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KategoriController/Create
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

        // GET: KategoriController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KategoriController/Edit/5
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

        // GET: KategoriController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KategoriController/Delete/5
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

