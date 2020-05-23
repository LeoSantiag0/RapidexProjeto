using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class Pedido_FinalizadoController : Controller
    {
        // GET: Pedido_FinalizadoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pedido_FinalizadoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pedido_FinalizadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pedido_FinalizadoController/Create
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

        // GET: Pedido_FinalizadoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pedido_FinalizadoController/Edit/5
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

        // GET: Pedido_FinalizadoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pedido_FinalizadoController/Delete/5
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
