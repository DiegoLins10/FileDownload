using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileDownload.Controllers
{
    public class DownloadController : Controller
    {
        // GET: DownloadController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DownloadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DownloadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DownloadController/Create
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

        // GET: DownloadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DownloadController/Edit/5
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

        // GET: DownloadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DownloadController/Delete/5
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
