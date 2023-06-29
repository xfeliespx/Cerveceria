using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using GestionAgilDeProyectos.Data;
using GestionAgilDeProyectos.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAgilDeProyectos.Controllers
{
    public class RegionController : Controller
    {
        private readonly ILogger<RegionController> _logger;
        private readonly ApplicationDbContext _context;
        public RegionController(ILogger<RegionController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Region.ToListAsync());
        }

        public IActionResult AddRegion()
        {
            return View();
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddRegion([Bind("Id,Nombre,FechaIngreso")] Region Region)
        {
            if (ModelState.IsValid)
            {
                var fechaing = DateTime.Now;

                Region.Id = Guid.NewGuid();
                Region.FechaIngreso = fechaing;
                _context.Add(Region);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(Region);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> EditRegion(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Region = await _context.Region.SingleOrDefaultAsync(m => m.Id == Id);
            if (Region == null)
            {
                return NotFound();
            }
            return View(Region);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditRegion(Guid id, [Bind("Id,Nombre,FechaIngreso,FechaActualizacion")] Region Region)
        {
            if (id != Region.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var fechaact = DateTime.Now;

                    Region.FechaActualizacion = fechaact;
                    _context.Update(Region);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegionExists(Region.Id))
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
            return View(Region);
        }

        [Authorize(Policy = "Admin")]
        private bool RegionExists(Guid Id)
        {
            return _context.Region.Any(e => e.Id == Id);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteRegion(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Region = await _context.Region
                .SingleOrDefaultAsync(m => m.Id == Id);
            if (Region == null)
            {
                return NotFound();
            }

            return View(Region);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost, ActionName("DeleteRegion")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid Id)
        {
            var Region = await _context.Region.SingleOrDefaultAsync(m => m.Id == Id);
            _context.Region.Remove(Region);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DetailsRegion(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Region = await _context.Region
                .SingleOrDefaultAsync(m => m.Id == Id);
            if (Region == null)
            {
                return NotFound();
            }

            return View(Region);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
