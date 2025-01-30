using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class DurumController : Controller
    {
        private IDurumService _DurumService;
        public DurumController()
        {
            _DurumService = new DurumService(new DurumRepository());

        }
        // GET: DurumController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DurumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DurumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DurumController/Create
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

        // GET: DurumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DurumController/Edit/5
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

        // GET: DurumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DurumController/Delete/5
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

