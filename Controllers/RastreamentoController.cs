using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class RastreamentoController : Controller
    {
        // GET: RastreamentoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RastreamentoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RastreamentoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RastreamentoController/Create
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

        // GET: RastreamentoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RastreamentoController/Edit/5
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

        // GET: RastreamentoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RastreamentoController/Delete/5
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
