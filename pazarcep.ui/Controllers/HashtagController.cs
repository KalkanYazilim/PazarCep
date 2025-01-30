using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class HashtagController : Controller
    {
        private IHashtagService _HashtagService;
        public HashtagController()
        {
            _HashtagService = new HashtagService(new HashtagRepository());

        }
        // GET: HashtagController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HashtagController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HashtagController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HashtagController/Create
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

        // GET: HashtagController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HashtagController/Edit/5
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

        // GET: HashtagController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HashtagController/Delete/5
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

