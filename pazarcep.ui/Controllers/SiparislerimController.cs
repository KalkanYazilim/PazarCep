using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class SiparislerimController : Controller
    {
        /*
        private ISiparislerimService _SiparislerimService;
        public SiparislerimController()
        {
            _SiparislerimService = new SiparislerimService(new SiparislerimRepository());
        
        }*/
        // GET: SiparislerimController
        public ActionResult Index()
        {
            //var SiparislerimListesi_Var = _SiparislerimService.GetAll();
            return View();
        }

        // GET: SiparislerimController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SiparislerimController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SiparislerimController/Create
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

        // GET: SiparislerimController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SiparislerimController/Edit/5
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

        // GET: SiparislerimController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SiparislerimController/Delete/5
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


