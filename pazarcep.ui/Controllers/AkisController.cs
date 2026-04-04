using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AkisController : Controller
    {
        /*
        private IAkisService _AkisService;
        public AkisController()
        {
            _AkisService = new AkisService(new AkisRepository());
        
        }*/
        // GET: AkisController
        public ActionResult Index()
        {
            //var AkisListesi_Var = _AkisService.GetAll();
            return View();
        }

        // GET: AkisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AkisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AkisController/Create
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

        // GET: AkisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AkisController/Edit/5
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

        // GET: AkisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AkisController/Delete/5
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


