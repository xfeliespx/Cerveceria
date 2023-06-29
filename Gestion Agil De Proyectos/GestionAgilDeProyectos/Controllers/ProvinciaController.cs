using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ProvinciaController : Controller
    {
        private readonly ILogger<ProvinciaController> _logger;
        private readonly ApplicationDbContext _context;
        public ProvinciaController(ILogger<ProvinciaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Provincia.ToListAsync());
        }

        [Authorize(Policy = "Admin")]
        public IActionResult AddProvincia()
        {
            return View();
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProvincia([Bind("Id,Nombre,FechaIngreso")] Provincia Provincia)
        {
            if (ModelState.IsValid)
            {
                var fechaing = DateTime.Now;

                Provincia.Id = Guid.NewGuid();
                Provincia.FechaIngreso = fechaing;
                _context.Add(Provincia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Provincia);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> EditProvincia(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Provincia = await _context.Provincia.SingleOrDefaultAsync(m => m.Id == Id);
            if (Provincia == null)
            {
                return NotFound();
            }
            return View(Provincia);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProvincia(Guid id, [Bind("Id,Nombre,FechaIngreso,FechaActualizacion")] Provincia Provincia)
        {
            if (id != Provincia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var fechaact = DateTime.Now;

                    Provincia.FechaActualizacion = fechaact;
                    _context.Update(Provincia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProvinciaExists(Provincia.Id))
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
            return View(Provincia);
        }

        [Authorize(Policy = "Admin")]
        private bool ProvinciaExists(Guid Id)
        {
            return _context.Provincia.Any(e => e.Id == Id);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteProvincia(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Provincia = await _context.Provincia
                .SingleOrDefaultAsync(m => m.Id == Id);
            if (Provincia == null)
            {
                return NotFound();
            }

            return View(Provincia);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost, ActionName("DeleteProvincia")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid Id)
        {
            var Provincia = await _context.Provincia.SingleOrDefaultAsync(m => m.Id == Id);
            _context.Provincia.Remove(Provincia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DetailsProvincia(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Provincia = await _context.Provincia
                .SingleOrDefaultAsync(m => m.Id == Id);
            if (Provincia == null)
            {
                return NotFound();
            }

            return View(Provincia);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
