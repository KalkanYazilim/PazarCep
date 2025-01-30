using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YukController : Controller
    {
        private IYukService _YukService;
        public YukController()
        {
            _YukService = new YukService(new YukRepository());

        }
        // GET: YukController
        public ActionResult Index()
        {
            var YukListesi_Var = _YukService.GetAll();
            return View(YukListesi_Var);
        }

        // GET: YukController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YukController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YukController/Create
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

        // GET: YukController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YukController/Edit/5
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

        // GET: YukController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YukController/Delete/5
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

