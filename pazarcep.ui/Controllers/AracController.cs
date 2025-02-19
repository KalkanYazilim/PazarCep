using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;
using pazarcep.entity.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AracController : Controller
    {
        private IAracService _aracService;
        public AracController()
        {
            _aracService = new AracService(new AracRepository()); //Repository'ye ba�l� olmamal�!

        }
        // GET: AracController
        public ActionResult Index()
        {
            var aracListesi = _aracService.GetAll();

            return View(aracListesi);
        }

        // GET: AracController/Details/5
        public ActionResult Details(int id)
        {
            if (id==null || id==0)
                return NotFound("Arac bulunamadi");
            var detail = _aracService.Get(x => x.Arac_ID == id);
            return View(detail);
        }

        // GET: AracController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AracController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Arac arac) //entity yerine DTO olu�turulmal�
        {
            if (ModelState.IsValid)
            {
                _aracService.Add(arac);
                return RedirectToAction(nameof(Index));
            }
            return View(arac);
        }

        // GET: AracController/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
                return NotFound("Ara� bulunamad�");

            var arac = _aracService.Get(x => x.Arac_ID == id);
            

            return View(arac);
        }

        // POST: AracController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Arac arac)  //entity yerine DTO olu�turulmal�
        {
            if (id != arac.Arac_ID)
                return BadRequest("Ara� bulunamad�");

            if (ModelState.IsValid)
            {
                _aracService.Update(arac);
                return RedirectToAction(nameof(Index));
            }
            return View(arac);
        }

        // GET: AracController/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
                return NotFound("Ara� bulunamad�");

            var arac = _aracService.Get(x => x.Arac_ID == id);
            

            return View(arac);
        }

        // POST: AracController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var arac = _aracService.Get(x => x.Arac_ID == id);
            if (arac == null)
                return NotFound("Ara� bulunamad�");

            _aracService.Delete(arac);
            return RedirectToAction(nameof(Index));
        }
    }
}

