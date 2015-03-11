using AutoMapper;
using Simds.Application.Interfaces;
using Simds.Domain.Entities;
using Simds.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simds.Mvc.Controllers
{
    public class PrefeituraController : Controller
    {
		private readonly IPrefeituraAppService _prefeituraApp;
		public PrefeituraController(IPrefeituraAppService prefeituraApp)
		{
			_prefeituraApp = prefeituraApp;
		}
        // GET: Prefeitura
        public ActionResult Index()
        {
			var prefeituraViewModel = Mapper.Map<IEnumerable<Prefeitura>, IEnumerable<PrefeituraViewModel>>(_prefeituraApp.GetAll());
			return View(prefeituraViewModel);
        }

        // GET: Prefeitura/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prefeitura/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prefeitura/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prefeitura/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prefeitura/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prefeitura/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prefeitura/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
