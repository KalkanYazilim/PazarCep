using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class SM_AnaSayfaController : Controller
    {
        /*
        private ISM_AnaSayfaService _SM_AnaSayfaService;
        public SM_AnaSayfaController()
        {
            _SM_AnaSayfaService = new SM_AnaSayfaService(new SM_AnaSayfaRepository());
        
        }*/
        // GET: SM_AnaSayfaController
        public ActionResult Index()
        {
            //var SM_AnaSayfaListesi_Var = _SM_AnaSayfaService.GetAll();
            return View();
        }

        // GET: SM_AnaSayfaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SM_AnaSayfaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SM_AnaSayfaController/Create
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

        // GET: SM_AnaSayfaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SM_AnaSayfaController/Edit/5
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

        // GET: SM_AnaSayfaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SM_AnaSayfaController/Delete/5
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


