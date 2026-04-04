using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class SepetimController : Controller
    {
        /*
        private ISepetimService _SepetimService;
        public SepetimController()
        {
            _SepetimService = new SepetimService(new SepetimRepository());
        
        }*/
        // GET: SepetimController
        public ActionResult Index()
        {
            //var SepetimListesi_Var = _SepetimService.GetAll();
            return View();
        }

        // GET: SepetimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SepetimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SepetimController/Create
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

        // GET: SepetimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SepetimController/Edit/5
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

        // GET: SepetimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SepetimController/Delete/5
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


