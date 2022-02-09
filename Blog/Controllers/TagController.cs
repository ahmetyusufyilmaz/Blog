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
    public class TagController : Controller
    {
        private readonly IRepositoryBase<Tag> _repositoryBase;

        public TagController(IRepositoryBase<Tag> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        // GET: Tag
        public async Task<IActionResult> Index()
        {
            var result = _repositoryBase.GetAll();
            return View();
        }

        // GET: Tag/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Tag/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tag/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,MetaTitle,Slug,Contents")] Tag tag)
        {
            var result = _repositoryBase.Add(tag);

            return View(tag);
        }

        // GET: Tag/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        // POST: Tag/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,MetaTitle,Slug,Contents")] Tag tag)
        {
            var selectedtag = _repositoryBase.Get(p => p.Id == id);
            selectedtag.Title = tag.Title;
            selectedtag.MetaTitle = tag.MetaTitle;
            selectedtag.Slug = tag.Slug;
            selectedtag.Contents = tag.Contents;
            selectedtag.Post = tag.Post;

            _repositoryBase.Update(selectedtag);
            return View();
        }

        // GET: Tag/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        // POST: Tag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            return RedirectToAction(nameof(Index));
        }

        private bool TagExists(int id)
        {
            return true;
        }
    }
}
