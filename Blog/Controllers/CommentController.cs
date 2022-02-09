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
    public class CommentController : Controller
    {
        private readonly IRepositoryBase<Comment> _repositoryBase;

        public CommentController(IRepositoryBase<Comment> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        // GET: Comment
        public async Task<IActionResult> Index()
        {
            var result = _repositoryBase.GetAll();
            return View();
        }

        // GET: Comment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: Comment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Published,CreatedAt,PublishedAt,Contents")] Comment comment)
        {
            var result = _repositoryBase.Add(comment);

            return View(comment);
        }

        // GET: Comment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
         
            return View();
        }

        // POST: Comment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Published,CreatedAt,PublishedAt,Contents")] Comment comment)
        {
            var selectedcomment = _repositoryBase.Get(p => p.Id == id);
            selectedcomment.Title = comment.Title;
            selectedcomment.Published = comment.Published;
            selectedcomment.CreatedAt = comment.CreatedAt;
            selectedcomment.Published = comment.Published;
            selectedcomment.Post = comment.Post;
            selectedcomment.Contents = comment.Contents;

            _repositoryBase.Update(selectedcomment);
            return View();
        }

        // GET: Comment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
        
            return View();
        }

        // POST: Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
            return true;
        }
    }
}
