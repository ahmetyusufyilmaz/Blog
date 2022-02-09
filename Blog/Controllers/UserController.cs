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
    public class UserController : Controller
    {
        private readonly IRepositoryBase<User> _repositoryBase;

        public UserController(IRepositoryBase<User> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            var result = _repositoryBase.GetAll();
            return View();
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            return View();
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Mobile,Email,Password,RegisteredAt,LastLogin,Intro,Profile")] User user)
        {
            var result = _repositoryBase.Add(user);

            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return View();
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Mobile,Email,Password,RegisteredAt,LastLogin,Intro,Profile")] User user)
        {
            var selecteduser = _repositoryBase.Get(p => p.Id == id);
            selecteduser.FirstName = user.FirstName;
            selecteduser.LastLogin = user.LastLogin;
            selecteduser.LastName = user.LastName;
            selecteduser.Mobile = user.Mobile;
            selecteduser.Email = user.Email;
            selecteduser.RegisteredAt = user.RegisteredAt;
            selecteduser.Password = user.Password;
            selecteduser.Intro = user.Intro;
            selecteduser.Profile = user.Profile;

            _repositoryBase.Update(selecteduser);
            return View();
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return true;
        }
    }
}
