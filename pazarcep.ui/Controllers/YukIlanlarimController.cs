using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YukIlanlarimController : Controller
    {
        /*
        private IYukIlanlarimService _YukIlanlarimService;
        public YukIlanlarimController()
        {
            _YukIlanlarimService = new YukIlanlarimService(new YukIlanlarimRepository());
        
        }*/
        // GET: YukIlanlarimController
        public ActionResult Index()
        {
            //var YukIlanlarimListesi_Var = _YukIlanlarimService.GetAll();
            return View();
        }

        // GET: YukIlanlarimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YukIlanlarimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YukIlanlarimController/Create
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

        // GET: YukIlanlarimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YukIlanlarimController/Edit/5
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

        // GET: YukIlanlarimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YukIlanlarimController/Delete/5
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


