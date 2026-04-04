using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class iletisimController : Controller
    {
        /*
        private IiletisimService _iletisimService;
        public iletisimController()
        {
            _iletisimService = new iletisimService(new iletisimRepository());
        
        }*/
        // GET: iletisimController
        public ActionResult Index()
        {
            //var iletisimListesi_Var = _iletisimService.GetAll();
            return View();
        }

        // GET: iletisimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: iletisimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: iletisimController/Create
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

        // GET: iletisimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: iletisimController/Edit/5
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

        // GET: iletisimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: iletisimController/Delete/5
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


