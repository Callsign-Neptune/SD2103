using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using BlockFriends.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BlockFriends.Controllers
{
    public class BuildUsersController : Controller
    {
        private readonly MinecraftSiteContext _context;
        private UserManager<IdentityUser> _userManager;
        private IHostingEnvironment _webroot;

        public BuildUsersController(MinecraftSiteContext context, UserManager<IdentityUser> userManager, IHostingEnvironment webroot )
        {
            _context = context;
            _userManager = userManager;
            _webroot = webroot;
        }

        // GET: BuildUsers
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.BuildUser.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> Browse()
        {
            return View(await _context.BuildUser.ToListAsync());
        }

        // GET: BuildUsers/Details/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildUser = await _context.BuildUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buildUser == null)
            {
                return NotFound();
            }

            return View(buildUser);
        }
        [Authorize]
        public async Task<IActionResult> Show(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildUser = await _context.BuildUser.FirstOrDefaultAsync(m => m.Id == id);

            if (buildUser == null)
            {
                return NotFound();
            }

            return View(buildUser);
        }

        // GET: BuildUsers/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: BuildUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Displayname,Firstname,Lastname,Bio,UserAccountId")] BuildUser buildUser, IFormFile FilePhoto)
        {
            if (FilePhoto.Length > 0)
            {
                string photoPath = _webroot.WebRootPath + "\\userPhotos\\";
                var fileName = Path.GetFileName(FilePhoto.FileName);

                using (var stream = System.IO.File.Create(photoPath + fileName))
                {
                    await FilePhoto.CopyToAsync(stream);
                    buildUser.PhotoPath = fileName;
                }
            }

            if (ModelState.IsValid)
            {
                _context.Add(buildUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProfileInfo));
            }
            return View(buildUser);
        }

        // GET: BuildUsers/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildUser = await _context.BuildUser.FindAsync(id);
            if (buildUser == null)
            {
                return NotFound();
            }
            return View(buildUser);
        }

        // POST: BuildUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Displayname,Firstname,Lastname,Bio,UserAccountId")] BuildUser buildUser)
        {
            if (id != buildUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buildUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuildUserExists(buildUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ProfileInfo));
            }
            return View(buildUser);
        }

        // GET: BuildUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildUser = await _context.BuildUser
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buildUser == null)
            {
                return NotFound();
            }

            return View(buildUser);
        }

        // POST: BuildUsers/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buildUser = await _context.BuildUser.FindAsync(id);
            _context.BuildUser.Remove(buildUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuildUserExists(int id)
        {
            return _context.BuildUser.Any(e => e.Id == id);
        }

        [Authorize]
        public IActionResult ProfileInfo()
        {
            string userID = _userManager.GetUserId(User);
            BuildUser profile = _context.BuildUser.FirstOrDefault(p => p.UserAccountId == userID);

            if (profile == null)
            {
                return RedirectToAction("Create");
            }

            return View(profile);
        }
    }
}
