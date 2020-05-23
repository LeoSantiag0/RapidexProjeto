using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class Frete_RapidoController : Controller
    {
        // GET: Frete_RapidoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Frete_RapidoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Frete_RapidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Frete_RapidoController/Create
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

        // GET: Frete_RapidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Frete_RapidoController/Edit/5
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

        // GET: Frete_RapidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Frete_RapidoController/Delete/5
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
