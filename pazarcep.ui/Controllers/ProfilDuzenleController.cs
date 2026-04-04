using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class ProfilDuzenleController : Controller
    {
        /*
        private IProfilDuzenleService _ProfilDuzenleService;
        public ProfilDuzenleController()
        {
            _ProfilDuzenleService = new ProfilDuzenleService(new ProfilDuzenleRepository());
        
        }*/
        // GET: ProfilDuzenleController
        public ActionResult Index()
        {
            //var ProfilDuzenleListesi_Var = _ProfilDuzenleService.GetAll();
            return View();
        }

        // GET: ProfilDuzenleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfilDuzenleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfilDuzenleController/Create
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

        // GET: ProfilDuzenleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfilDuzenleController/Edit/5
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

        // GET: ProfilDuzenleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfilDuzenleController/Delete/5
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


