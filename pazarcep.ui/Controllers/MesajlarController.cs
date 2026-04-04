using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class MesajlarController : Controller
    {
        /*
        private IMesajlarService _MesajlarService;
        public MesajlarController()
        {
            _MesajlarService = new MesajlarService(new MesajlarRepository());
        
        }*/
        // GET: MesajlarController
        public ActionResult Index()
        {
            //var MesajlarListesi_Var = _MesajlarService.GetAll();
            return View();
        }

        // GET: MesajlarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MesajlarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesajlarController/Create
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

        // GET: MesajlarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MesajlarController/Edit/5
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

        // GET: MesajlarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesajlarController/Delete/5
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


