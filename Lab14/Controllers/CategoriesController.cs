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
    
    public class CategoriesController : Controller
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
        // GET: Categories
        public ActionResult Index()
        {
            return View(contexto.Categories.ToList());
        }

        public ActionResult Details (int id)
        {
            var productoPorCategoria = from p in contexto.Products
                                       orderby p.ProductName ascending
                                       where p.CategoryID == id
                                       select p;
            return View(productoPorCategoria.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create (Category nuevaCategoria)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Categories.Add(nuevaCategoria);
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nuevaCategoria);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Category CategoriaEditar = contexto.Categories.Find(id);

            if (CategoriaEditar == null)
                return HttpNotFound();

            return View(CategoriaEditar);
        }
        [HttpPost]
        public ActionResult Edit(Category categoriaEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contexto.Entry(categoriaEditar).State = EntityState.Modified;
                    contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(categoriaEditar);
            }
            catch
            {
                return View();
            }
            
        }
        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Category categoriaEliminar = contexto.Categories.Find(id);

            if(categoriaEliminar == null)
                return HttpNotFound();

            return View(categoriaEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Category categoria)
        {
            try
            {
                Category categoriaEliminar = new Category();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    categoriaEliminar = contexto.Categories.Find(id);

                    if (categoriaEliminar == null)
                        return HttpNotFound();

                    contexto.Categories.Remove(categoriaEliminar);
                    contexto.SaveChanges();
                    return RedirectToAction("Index");
                    
                }
                return View(categoriaEliminar);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ShowProductEdit(int? id)
        {
            return RedirectToAction("Edit","Product", new { id = id });
        }
        public ActionResult ShowProductDetails (int? id)
        {
            return RedirectToAction("Details","Product", new { id = id});
        }
        public ActionResult ProductDelete(int? id)
        {
            return RedirectToAction("Delete", "Product", new { id = id });
        }
    }
}