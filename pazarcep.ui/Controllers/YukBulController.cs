using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YukBulController : Controller
    {
        /*
        private IYukBulService _YukBulService;
        public YukBulController()
        {
            _YukBulService = new YukBulService(new YukBulRepository());
        
        }*/
        // GET: YukBulController
        public ActionResult Index()
        {
            //var YukBulListesi_Var = _YukBulService.GetAll();
            return View();
        }

        // GET: YukBulController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YukBulController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YukBulController/Create
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

        // GET: YukBulController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YukBulController/Edit/5
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

        // GET: YukBulController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YukBulController/Delete/5
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


