using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YukAlan_BilgisiController : Controller
    {
        private IYukAlan_BilgisiService _YukAlan_BilgisiService;
        public YukAlan_BilgisiController()
        {
            _YukAlan_BilgisiService = new YukAlan_BilgisiService(new YukAlan_BilgisiRepository());

        }
        // GET: YukAlan_BilgisiController
        public ActionResult Index()
        {
            var YukAlan_BilgisiListesi_Var = _YukAlan_BilgisiService.GetAll();
            return View(YukAlan_BilgisiListesi_Var);
        }

        // GET: YukAlan_BilgisiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YukAlan_BilgisiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YukAlan_BilgisiController/Create
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

        // GET: YukAlan_BilgisiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YukAlan_BilgisiController/Edit/5
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

        // GET: YukAlan_BilgisiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YukAlan_BilgisiController/Delete/5
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

