using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class Resumo_do_PedidoController : Controller
    {
        // GET: Resumo_do_PedidoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Resumo_do_PedidoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Resumo_do_PedidoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Resumo_do_PedidoController/Create
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

        // GET: Resumo_do_PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Resumo_do_PedidoController/Edit/5
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

        // GET: Resumo_do_PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Resumo_do_PedidoController/Delete/5
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
