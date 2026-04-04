using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class GirisController : Controller
    {
        /*
        private IGirisService _GirisService;
        public GirisController()
        {
            _GirisService = new GirisService(new GirisRepository());
        
        }*/
        // GET: GirisController
        public ActionResult Index()
        {
            //var GirisListesi_Var = _GirisService.GetAll();
            return View();
        }

        // GET: GirisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GirisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GirisController/Create
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

        // GET: GirisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GirisController/Edit/5
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

        // GET: GirisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GirisController/Delete/5
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


