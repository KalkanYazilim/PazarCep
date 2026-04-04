using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class ilanController : Controller
    {
        private IilanService _ilanService;
        public ilanController()
        {
            _ilanService = new ilanService(new ilanRepository());

        }
        // GET: ilanController
        public ActionResult Index()
        {
            var ilanListesi_Var = _ilanService.GetAll();
            return View(ilanListesi_Var);
        }

        // GET: ilanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ilanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ilanController/Create
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

        // GET: ilanController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ilanController/Edit/5
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

        // GET: ilanController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ilanController/Delete/5
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

