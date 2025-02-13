using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class UrunDetayController : Controller
    {
        /*
        private IUrunDetayService _UrunDetayService;
        public UrunDetayController()
        {
            _UrunDetayService = new UrunDetayService(new UrunDetayRepository());
        
        }*/
        // GET: UrunDetayController
        public ActionResult Index()
        {
            //var UrunDetayListesi_Var = _UrunDetayService.GetAll();
            return View();
        }

        // GET: UrunDetayController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunDetayController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunDetayController/Create
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

        // GET: UrunDetayController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunDetayController/Edit/5
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

        // GET: UrunDetayController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunDetayController/Delete/5
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


