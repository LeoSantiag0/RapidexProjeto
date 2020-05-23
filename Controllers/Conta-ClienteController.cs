using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class Conta_ClienteController : Controller
    {
        // GET: Conta_ClienteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Conta_ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Conta_ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conta_ClienteController/Create
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

        // GET: Conta_ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Conta_ClienteController/Edit/5
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

        // GET: Conta_ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conta_ClienteController/Delete/5
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
