using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class SSSController : Controller
    {
        /*
        private ISSSService _SSSService;
        public SSSController()
        {
            _SSSService = new SSSService(new SSSRepository());
        
        }*/
        // GET: SSSController
        public ActionResult Index()
        {
            //var SSSListesi_Var = _SSSService.GetAll();
            return View();
        }

        // GET: SSSController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SSSController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SSSController/Create
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

        // GET: SSSController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SSSController/Edit/5
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

        // GET: SSSController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SSSController/Delete/5
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


