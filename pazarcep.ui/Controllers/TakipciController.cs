using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class TakipciController : Controller
    {
        private ITakipciService _TakipciService;
        public TakipciController()
        {
            _TakipciService = new TakipciService(new TakipciRepository());

        }
        // GET: TakipciController
        public ActionResult Index()
        {
            var TakipciListesi_Var = _TakipciService.GetAll();
            return View(TakipciListesi_Var);
        }

        // GET: TakipciController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TakipciController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TakipciController/Create
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

        // GET: TakipciController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TakipciController/Edit/5
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

        // GET: TakipciController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TakipciController/Delete/5
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

