using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blog.DataAccess;
using Blog.Models;
using Blog.DataAccess.EntityFramework;

namespace Blog.Controllers
{
    public class CategoryController : Controller
    {
      
        private readonly IRepositoryBase<Category> _repositoryBase;

        public CategoryController(IRepositoryBase<Category> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        // GET: Categories
        public IActionResult GetCategories()
        {
            var result = _repositoryBase.GetAll();
            return View(result);
        }

        // GET: Categories/Details/5
        public IActionResult Details(int? id)
        {
            var result = _repositoryBase.Get(c => c.Id == id);
            return View(result);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,MetaTitle,Slug,Contents")] Category category)
        {
            var result = _repositoryBase.Add(category);

            return View(category);
        }

        // GET: Categories/Edit/5
        public IActionResult Edit(int? id)
        {
            var result = _repositoryBase.Get(c => c.Id == id);
            return View(result);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,MetaTitle,Slug,Contents")] Category category)
        {
            var selectedcategory = _repositoryBase.Get(p => p.Id == id);
            selectedcategory.MetaTitle = category.MetaTitle;
            selectedcategory.Title = category.Title;
            selectedcategory.Slug = category.Slug;
            selectedcategory.Contents = category.Contents;

            _repositoryBase.Update(selectedcategory);
            return View();
        }

        // GET: Categories/Delete/5
        public IActionResult Delete(int? id)
        {
            var result = _repositoryBase.Get(c => c.Id == id);
            _repositoryBase.Delete(result);
            return RedirectToAction(nameof(Index));
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
           
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return true;
        }
    }
}
