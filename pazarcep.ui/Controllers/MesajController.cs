using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class MesajController : Controller
    {
        private IMesajService _MesajService;
        public MesajController()
        {
            _MesajService = new MesajService(new MesajRepository());

        }
        // GET: MesajController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MesajController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MesajController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MesajController/Create
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

        // GET: MesajController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MesajController/Edit/5
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

        // GET: MesajController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MesajController/Delete/5
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

