using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class UrunEkleController : Controller
    {
        /*
        private IUrunEkleService _UrunEkleService;
        public UrunEkleController()
        {
            _UrunEkleService = new UrunEkleService(new UrunEkleRepository());
        
        }*/
        // GET: UrunEkleController
        public ActionResult Index()
        {
            //var UrunEkleListesi_Var = _UrunEkleService.GetAll();
            return View();
        }

        // GET: UrunEkleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunEkleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunEkleController/Create
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

        // GET: UrunEkleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunEkleController/Edit/5
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

        // GET: UrunEkleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunEkleController/Delete/5
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


