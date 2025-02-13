using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AdminPaneliController : Controller
    {
        /*
        private IAdminPaneliService _AdminPaneliService;
        public AdminPaneliController()
        {
            _AdminPaneliService = new AdminPaneliService(new AdminPaneliRepository());
        
        }*/
        // GET: AdminPaneliController
        public ActionResult Index()
        {
            //var AdminPaneliListesi_Var = _AdminPaneliService.GetAll();
            return View();
        }

        // GET: AdminPaneliController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminPaneliController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPaneliController/Create
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

        // GET: AdminPaneliController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminPaneliController/Edit/5
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

        // GET: AdminPaneliController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminPaneliController/Delete/5
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


