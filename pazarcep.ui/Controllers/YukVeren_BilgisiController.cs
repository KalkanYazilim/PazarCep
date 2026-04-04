using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YukVeren_BilgisiController : Controller
    {
        private IYukVeren_BilgisiService _YukVeren_BilgisiService;
        public YukVeren_BilgisiController()
        {
            _YukVeren_BilgisiService = new YukVeren_BilgisiService(new YukVeren_BilgisiRepository());

        }
        // GET: YukVeren_BilgisiController
        public ActionResult Index()
        {
            var YukVeren_BilgisiListesi_Var = _YukVeren_BilgisiService.GetAll();
            return View(YukVeren_BilgisiListesi_Var);
        }

        // GET: YukVeren_BilgisiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YukVeren_BilgisiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YukVeren_BilgisiController/Create
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

        // GET: YukVeren_BilgisiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YukVeren_BilgisiController/Edit/5
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

        // GET: YukVeren_BilgisiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YukVeren_BilgisiController/Delete/5
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

