using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class SM_ProfilController : Controller
    {
        /*
        private ISM_ProfilService _SM_ProfilService;
        public SM_ProfilController()
        {
            _SM_ProfilService = new SM_ProfilService(new SM_ProfilRepository());
        
        }*/
        // GET: SM_ProfilController
        public ActionResult Index()
        {
            //var SM_ProfilListesi_Var = _SM_ProfilService.GetAll();
            return View();
        }

        // GET: SM_ProfilController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SM_ProfilController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SM_ProfilController/Create
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

        // GET: SM_ProfilController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SM_ProfilController/Edit/5
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

        // GET: SM_ProfilController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SM_ProfilController/Delete/5
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


