using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AnaSayfaController : Controller
    {
        /*
        private IAnaSayfaService _AnaSayfaService;
        public AnaSayfaController()
        {
            _AnaSayfaService = new AnaSayfaService(new AnaSayfaRepository());
        
        }*/
        // GET: AnaSayfaController
        public ActionResult Index()
        {
            //var AnaSayfaListesi_Var = _AnaSayfaService.GetAll();
            return View();
        }

        // GET: AnaSayfaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnaSayfaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnaSayfaController/Create
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

        // GET: AnaSayfaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnaSayfaController/Edit/5
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

        // GET: AnaSayfaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnaSayfaController/Delete/5
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


