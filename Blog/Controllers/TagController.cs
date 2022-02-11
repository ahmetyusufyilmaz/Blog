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
        private readonly ITagRepository _ITagRepository;

        public TagController(ITagRepository repositoryBase)
        {
            _ITagRepository = repositoryBase;
        }

        // GET: Tag
        public IActionResult Index()
        {
            var result = _ITagRepository.GetAll();
            return View(result);
        }

        // GET: Tag/Details/5
        public IActionResult Details(int? id)
        {
            var result = _ITagRepository.Get(t => t.Id == id);
            return View(result);
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
        public IActionResult Create([Bind("Id,Title,MetaTitle,Slug,Contents")] Tag tag)
        {
            var result = _ITagRepository.Add(tag);

            return View(tag);
        }

        // GET: Tag/Edit/5
        public IActionResult Edit(int? id)
        {
            var result = _ITagRepository.Get(t => t.Id == id);
            return View(result);
        }

        // POST: Tag/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,MetaTitle,Slug,Contents")] Tag tag)
        {
            var selectedtag = _ITagRepository.Get(p => p.Id == id);
            selectedtag.Title = tag.Title;
            selectedtag.MetaTitle = tag.MetaTitle;
            selectedtag.Slug = tag.Slug;
            selectedtag.Contents = tag.Contents;
            selectedtag.Post = tag.Post;

            _ITagRepository.Update(selectedtag);
            return View();
        }

        // GET: Tag/Delete/5
        public IActionResult Delete(int? id)
        {
            var result = _ITagRepository.Get(t => t.Id == id);
            _ITagRepository.Delete(result);
            return RedirectToAction(nameof(Index));
        }

        // POST: Tag/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
           
            return RedirectToAction(nameof(Index));
        }

        private bool TagExists(int id)
        {
            return true;
        }
    }
}
