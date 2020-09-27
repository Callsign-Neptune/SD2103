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
    public class BuildTablesController : Controller
    {
        private readonly MinecraftSiteContext _context;
        private UserManager<IdentityUser> _userManager;
        private IHostingEnvironment _webroot;

        public BuildTablesController(MinecraftSiteContext context, UserManager<IdentityUser> userManager, IHostingEnvironment webroot )
        {
            _context = context;
            _userManager = userManager;
            _webroot = webroot;
        }

        public IActionResult List()
        {
            IEnumerable<BuildTable> posts = _context.BuildTable.ToList<BuildTable>();
            return View(posts);
        }

        // GET: BuildTables
        public async Task<IActionResult> Index()
        {
            var minecraftSiteContext = _context.BuildTable.Include(b => b.Profile);
            return View(await _context.BuildTable.ToListAsync());
        }

        // GET: BuildTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildTable = await _context.BuildTable
                .Include(b => b.Profile)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buildTable == null)
            {
                return NotFound();
            }

            return View(buildTable);
        }

        // GET: BuildTables/Create
        public IActionResult Create()
        {
            ViewData["ProfileId"] = new SelectList(_context.BuildUser, "Id", "Bio");
            return View();
        }

        // POST: BuildTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Buildname,BuildContent,MaterialUsed,BuildTime,BuildBiome,ProfileId,BuilderNum,WorldSeed,BuildDate")] BuildTable buildTable, IFormFile FilePhoto)
        {
            if (FilePhoto.Length > 0)
            {
                string buildPhoto = _webroot.WebRootPath + "\\buildPhotos\\";
                var fileName = Path.GetFileName(FilePhoto.FileName);

                using (var stream = System.IO.File.Create(buildPhoto + fileName))
                {
                    await FilePhoto.CopyToAsync(stream);
                    buildTable.BuildPhoto = fileName;
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(buildTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfileId"] = new SelectList(_context.BuildUser, "Id", "Bio", buildTable.ProfileId);
            return View(buildTable);
        }

        // GET: BuildTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildTable = await _context.BuildTable.FindAsync(id);
            if (buildTable == null)
            {
                return NotFound();
            }
            ViewData["ProfileId"] = new SelectList(_context.BuildUser, "Id", "Bio", buildTable.ProfileId);
            return View(buildTable);
        }

        // POST: BuildTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Buildname,BuildContent,MaterialUsed,BuildTime,BuildBiome,ProfileId,BuilderNum,WorldSeed,BuildPhoto,BuildDate")] BuildTable buildTable, IFormFile FIlePhoto)
        {
            if (id != buildTable.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buildTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuildTableExists(buildTable.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfileId"] = new SelectList(_context.BuildUser, "Id", "Bio", buildTable.ProfileId);
            return View(buildTable);
        }

        // GET: BuildTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buildTable = await _context.BuildTable
                .Include(b => b.Profile)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buildTable == null)
            {
                return NotFound();
            }

            return View(buildTable);
        }

        // POST: BuildTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buildTable = await _context.BuildTable.FindAsync(id);
            _context.BuildTable.Remove(buildTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuildTableExists(int id)
        {
            return _context.BuildTable.Any(e => e.Id == id);
        }
    }
}
