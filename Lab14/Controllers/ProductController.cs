using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab14.Models;
using System.Net;
using System.Data.Entity;

namespace Lab14.Controllers
{
    public class ProductController : Controller
    {
        private NORTHWNDEntities _contexto;
        public NORTHWNDEntities contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new NORTHWNDEntities();
                return _contexto;
            }
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Product productoEditar = contexto.Products.Find(id);

            if (productoEditar == null)
                return HttpNotFound();

            return View(productoEditar);
        }
        [HttpPost]
        public ActionResult Edit (Product productEdit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Entry(productEdit).State = EntityState.Modified;
                    contexto.SaveChanges();
                    return RedirectToAction("Index","Categories");
                }
                return View(productEdit);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details (int? id)
        {
            var producto = contexto.Products.Find(id);
            return View(producto);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Product producto = contexto.Products.Find(id);

            if (producto == null)
                return HttpNotFound();

            return View(producto);
        }
        [HttpPost]
        public ActionResult Delete(int? id, Product producto)
        {
            try
            {
                Product productoDelete = contexto.Products.Find(id);
                contexto.Products.Remove(productoDelete);
                contexto.SaveChanges();     
            }
            catch
            {
                return View("Delete", new { id = id});
            }
            return RedirectToAction("Index", "Categories");
        }
    }
}