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
    public class ComunaController : Controller
    {
        private readonly ILogger<ComunaController> _logger;
        private readonly ApplicationDbContext _context;
        public ComunaController(ILogger<ComunaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Comuna.Include(s => s.Provincia);
            return View(await applicationDbContext.ToListAsync());
        }

        [Authorize(Policy = "Admin")]
        public IActionResult AddComuna()
        {
            ViewData["ProvinciaID"] = new SelectList(_context.Provincia.OrderBy(item => item.Nombre), "Id", "Nombre");
            return View();
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComuna([Bind("Id,ProvinciaID,Nombre,FechaIngreso")] Comuna Comuna)
        {
            if (ModelState.IsValid)
            {
                var fechaing = DateTime.Now;

                Comuna.Id = Guid.NewGuid();
                Comuna.FechaIngreso = fechaing;
                _context.Add(Comuna);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }         
            ViewData["ProvinciaID"] = new SelectList(_context.Provincia.OrderBy(item => item.Nombre), "Id", "Nombre", Provincia.ProvinciaID);

            return View(Comuna);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> EditComuna(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Comuna = await _context.Comuna.Include(s => s.Provincia).SingleOrDefaultAsync(m => m.Id == Id);
            if (Comuna == null)
            {
                return NotFound();
            }
            ViewData["ProvinciaID"] = new SelectList(_context.Provincia.OrderBy(item => item.Nombre), "Id", "Nombre", Comuna.ProvinciaID);
            return View(Comuna);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditComuna(Guid id, [Bind("Id,ProvinciaID,Nombre,FechaIngreso,FechaActualizacion")] Comuna Comuna)
        {
            if (id != Comuna.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var fechaact = DateTime.Now;

                    Comuna.FechaActualizacion = fechaact;
                    _context.Update(Comuna);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComunaExists(Comuna.Id))
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
            ViewData["ProvinciaID"] = new SelectList(_context.Provincia.OrderBy(item => item.Nombre), "Id", "Nombre", Provincia.ProvinciaID);
            return View(Comuna);
        }

        [Authorize(Policy = "Admin")]
        private bool ComunaExists(Guid Id)
        {
            return _context.Comuna.Any(e => e.Id == Id);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteComuna(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Comuna = await _context.Comuna.Include(x => x.Provincia)
                .SingleOrDefaultAsync(m => m.Id == Id);
            if (Comuna == null)
            {
                return NotFound();
            }

            return View(Comuna);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost, ActionName("DeleteComuna")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid Id)
        {
            var Comuna = await _context.Comuna.SingleOrDefaultAsync(m => m.Id == Id);
            _context.Comuna.Remove(Comuna);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DetailsComuna(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Comuna = await _context.Comuna.Include(x => x.Provincia)
                .SingleOrDefaultAsync(m => m.Id == Id);
            if (Comuna == null)
            {
                return NotFound();
            }

            return View(Comuna);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}