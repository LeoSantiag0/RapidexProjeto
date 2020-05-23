using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aplicacaoWeb.Controllers
{
    public class Frete_NacionalHomeController : Controller
    {
        // GET: Frete_NacionalHomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: Frete_NacionalHomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Frete_NacionalHomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Frete_NacionalHomeController/Create
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

        // GET: Frete_NacionalHomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Frete_NacionalHomeController/Edit/5
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

        // GET: Frete_NacionalHomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Frete_NacionalHomeController/Delete/5
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
