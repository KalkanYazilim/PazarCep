using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class KesfetController : Controller
    {
        /*
        private IKesfetService _KesfetService;
        public KesfetController()
        {
            _KesfetService = new KesfetService(new KesfetRepository());
        
        }*/
        // GET: KesfetController
        public ActionResult Index()
        {
            //var KesfetListesi_Var = _KesfetService.GetAll();
            return View();
        }

        // GET: KesfetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KesfetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KesfetController/Create
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

        // GET: KesfetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KesfetController/Edit/5
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

        // GET: KesfetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KesfetController/Delete/5
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


