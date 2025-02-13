using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class TekliflerimController : Controller
    {
        /*
        private ITekliflerimService _TekliflerimService;
        public TekliflerimController()
        {
            _TekliflerimService = new TekliflerimService(new TekliflerimRepository());
        
        }*/
        // GET: TekliflerimController
        public ActionResult Index()
        {
            //var TekliflerimListesi_Var = _TekliflerimService.GetAll();
            return View();
        }

        // GET: TekliflerimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TekliflerimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TekliflerimController/Create
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

        // GET: TekliflerimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TekliflerimController/Edit/5
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

        // GET: TekliflerimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TekliflerimController/Delete/5
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


