using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class PagamentoeController : Controller
    {
        // GET: PagamentoeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PagamentoeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PagamentoeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PagamentoeController/Create
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

        // GET: PagamentoeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagamentoeController/Edit/5
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

        // GET: PagamentoeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PagamentoeController/Delete/5
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
