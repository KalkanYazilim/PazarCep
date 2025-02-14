﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pazarcep.dataaccess.Concretes.Repositories;
using PazarCep.Business.Abstracts;
using PazarCep.Business.Concretes;


namespace pazarcep.ui.Controllers
{
    public class AdresController : Controller
    {
        private IAdresService _adresService;
        public AdresController()
        {
            _adresService = new AdresService(new AdresRepository());

        }
        // GET: AdresController
        public ActionResult Index()
        {
            var AdresListesi_Var = _adresService.GetAll();
            return View(AdresListesi_Var);
        }

        // GET: AdresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdresController/Create
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

        // GET: AdresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdresController/Edit/5
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

        // GET: AdresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdresController/Delete/5
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
