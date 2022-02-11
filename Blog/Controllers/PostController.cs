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
    /*[Route("/[controller]s")] */
    
    public class PostController : Controller
    {
       
        private readonly IPostRepository _IPostRepository;

        public PostController(IPostRepository IPostRepository)
        {
            _IPostRepository = IPostRepository;
        }

        // GET: Post
        public IActionResult Index()
        {
           var result = _IPostRepository.GetAll();
           
            return View(result);
        }
        public IActionResult Index2()
        {
            var result = _IPostRepository.GetAll();

            return View(result);
        }

        // GET: Post/Details/5
        public IActionResult Details(int? id)
        {
            var result = _IPostRepository.Get(p => p.Id == id);
            return View(result);
        }

        // GET: Post/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("Id,Title,MetaTitle,Slug,Summary,Published,CreatedAt,UpdatedAt,PublishedAt,Contents")] Post post)
        {
            var result = _IPostRepository.Add(post);

            return View(post);
        }

        // GET: Post/Edit/5
        public IActionResult Edit(int? id)
        {

            var result = _IPostRepository.Get(p => p.Id == id);
            return View(result);
        }

        // POST: Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,MetaTitle,Slug,Summary,Published,CreatedAt,UpdatedAt,PublishedAt,Contents")] Post post)
        {
            var selectedpost = _IPostRepository.Get(p => p.Id == id);
            selectedpost.MetaTitle = post.MetaTitle;
            selectedpost.Title = post.Title;
            selectedpost.Published = post.Published;
            selectedpost.PublishedAt = post.PublishedAt;
            selectedpost.Categories = post.Categories;
            selectedpost.Contents = post.Contents;
            selectedpost.CreatedAt = post.CreatedAt;
            selectedpost.Slug = post.Slug;
            selectedpost.Summary= post.Summary;
            selectedpost.Tags = post.Tags;
            selectedpost.UpdatedAt = post.UpdatedAt;
            selectedpost.User = post.User;

            _IPostRepository.Update(selectedpost);
            return View();
        }

        // GET: Post/Delete/5
        public IActionResult Delete(int? id)
        {
            var result = _IPostRepository.Get(p => p.Id == id);
            _IPostRepository.Delete(result);
            return RedirectToAction(nameof(Index));
        }

        // POST: Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {

            return RedirectToAction(nameof(Index));
        }

        private bool PostExists(int id)
        {
            return true;
        }
    }
}
