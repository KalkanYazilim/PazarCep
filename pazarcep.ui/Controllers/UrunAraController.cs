using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class UrunAraController : Controller
    {
        /*
        private IUrunAraService _UrunAraService;
        public UrunAraController()
        {
            _UrunAraService = new UrunAraService(new UrunAraRepository());
        
        }*/
        // GET: UrunAraController
        public ActionResult Index()
        {
            //var UrunAraListesi_Var = _UrunAraService.GetAll();
            return View();
        }

        // GET: UrunAraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UrunAraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UrunAraController/Create
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

        // GET: UrunAraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UrunAraController/Edit/5
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

        // GET: UrunAraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UrunAraController/Delete/5
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


