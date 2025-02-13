using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class UrunlerimController : Controller
    {
        /*
        private IUrunlerimService _UrunlerimService;
        public UrunlerimController()
        {
            _UrunlerimService = new UrunlerimService(new UrunlerimRepository());
        
        }*/
        // GET: UrunlerimController
        public ActionResult Index()
        {
            //var UrunlerimListesi_Var = _UrunlerimService.GetAll();
            return View();
        }

        // GET: UrunlerimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunlerimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunlerimController/Create
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

        // GET: UrunlerimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunlerimController/Edit/5
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

        // GET: UrunlerimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunlerimController/Delete/5
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


