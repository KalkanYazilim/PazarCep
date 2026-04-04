using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class OdemeController : Controller
    {
        /*
        private IOdemeService _OdemeService;
        public OdemeController()
        {
            _OdemeService = new OdemeService(new OdemeRepository());
        
        }*/
        // GET: OdemeController
        public ActionResult Index()
        {
            //var OdemeListesi_Var = _OdemeService.GetAll();
            return View();
        }

        // GET: OdemeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OdemeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OdemeController/Create
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

        // GET: OdemeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OdemeController/Edit/5
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

        // GET: OdemeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OdemeController/Delete/5
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


