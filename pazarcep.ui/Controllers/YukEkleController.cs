using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YukEkleController : Controller
    {
        /*
        private IYukEkleService _YukEkleService;
        public YukEkleController()
        {
            _YukEkleService = new YukEkleService(new YukEkleRepository());
        
        }*/
        // GET: YukEkleController
        public ActionResult Index()
        {
            //var YukEkleListesi_Var = _YukEkleService.GetAll();
            return View();
        }

        // GET: YukEkleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YukEkleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YukEkleController/Create
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

        // GET: YukEkleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YukEkleController/Edit/5
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

        // GET: YukEkleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YukEkleController/Delete/5
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


