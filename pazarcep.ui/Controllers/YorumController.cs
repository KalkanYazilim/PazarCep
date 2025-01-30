using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class YorumController : Controller
    {
        private IYorumService _YorumService;
        public YorumController()
        {
            _YorumService = new YorumService(new YorumRepository());

        }
        // GET: YorumController
        public ActionResult Index()
        {
            var YorumListesi_Var = _YorumService.GetAll();
            return View(YorumListesi_Var);
        }

        // GET: YorumController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: YorumController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: YorumController/Create
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

        // GET: YorumController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: YorumController/Edit/5
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

        // GET: YorumController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: YorumController/Delete/5
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

