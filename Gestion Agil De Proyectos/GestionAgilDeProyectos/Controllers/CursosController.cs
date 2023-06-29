using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using GestionAgilDeProyectos.Data;
using GestionAgilDeProyectos.Models;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GestionAgilDeProyectos.Controllers
{
    public class CursosController : Controller
    {
        private readonly ILogger<CursosController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IConfiguration Configuration;
		private readonly string _connectionString;
		private readonly UserManager<ApplicationUser> _userManager;

        public CursosController(ILogger<CursosController> logger, ApplicationDbContext context, IWebHostEnvironment webHostEnvironment, IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
            Configuration = configuration;
			_connectionString = configuration.GetConnectionString("DefaultConnection");
			_userManager = userManager;
		}

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cursos.Include(s => s.Comuna);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Cursos()
        {
            return View(await _context.Cursos.Include(s => s.Comuna).ToListAsync());
        }

        [Authorize(Policy = "Admin")]
        public IActionResult AddCursos()
        {
            ViewData["ComunaID"] = new SelectList(_context.Comuna.OrderBy(item => item.Nombre), "Id", "Nombre");
            return View();
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCursos([Bind("Id,Nombre,Apellido,RUT,Direccion,Descripcion,Logo,Portada,FechaCurso,FechaIngreso,ValorPeso,ValorUF,Habitacion,Bannio,Estado,tamannio,ComunaID,Telefono")] Cursos Cursos, IFormFile Portada, IFormFile Logo)
        {
            if (ModelState.IsValid)
            {
                string ruta = this.Configuration.GetConnectionString("Link");
                var nombre = Cursos.Nombre;
                string fileName = Logo.FileName;
                fileName = Path.GetFileName(fileName);
                string directorio = Path.Combine("wwwroot\\images", nombre, "Logo");

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                string uploadpath = Path.Combine("wwwroot\\images", nombre, "Logo", fileName);
                var stream = new FileStream(uploadpath, FileMode.Create);
                string path = ruta + "images/" + nombre + "/" + "Logo/" + fileName;
                _ = Logo.CopyToAsync(stream);               
                string fileName2 = Portada.FileName;
                fileName2 = Path.GetFileName(fileName2);
                string directorio2 = Path.Combine("wwwroot\\images", nombre, "Portada");

                if (!Directory.Exists(directorio2))
                {
                    Directory.CreateDirectory(directorio2);
                }

                string uploadpath2 = Path.Combine("wwwroot\\images", nombre, "Portada", fileName2);
                var stream2 = new FileStream(uploadpath2, FileMode.Create);
                string path2 = ruta + "images/" + nombre + "/" + "Portada/" + fileName2;
                _ = Portada.CopyToAsync(stream2);

				Cursos.Id = Guid.NewGuid();
				Cursos.FechaIngreso = DateTime.Now;
                Cursos.Logo = path;
                Cursos.Estado = "Disponible";
				Cursos.Portada = path2;
                _context.Add(Cursos);
                await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
            }

            ViewData["ComunaID"] = new SelectList(_context.Comuna.OrderBy(item => item.Nombre), "Id", "Nombre", Comuna.ComunaID);

			return View(Cursos);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> EditCursos(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Cursos = await _context.Cursos.SingleOrDefaultAsync(m => m.Id == Id);
            if (Cursos == null)
            {
                return NotFound();
            }

            ViewData["ComunaID"] = new SelectList(_context.Comuna.OrderBy(item => item.Nombre), "Id", "Nombre", Cursos.ComunaID);
            return View(Cursos);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCursos(Guid id, [Bind("Id,Nombre,Apellido,RUT,Direccion,Descripcion,Logo,Portada,FechaCurso,FechaIngreso,FechaActualizacion,ValorPeso,ValorUF,Habitacion,Bannio,Estado,tamannio,ComunaID,Telefono")] Cursos Cursos, IFormFile Portada, IFormFile Logo)
        {
            if (id != Cursos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (Portada != null && Logo != null) {

                        string ruta = Configuration.GetConnectionString("Link");
                        var nombre = Cursos.Nombre;
                        string fileName = Logo.FileName;
                        fileName = Path.GetFileName(fileName);
                        string directorio = Path.Combine("wwwroot\\images", nombre, "Logo");

                        if (!Directory.Exists(directorio))
                        {
                            Directory.CreateDirectory(directorio);
                        }

                        string uploadpath = Path.Combine("wwwroot\\images", nombre, "Logo", fileName);
                        var stream = new FileStream(uploadpath, FileMode.Create);
                        string path = ruta + "images/" + nombre + "/" + "Logo/" + fileName;
                        _ = Logo.CopyToAsync(stream);
                        string fileName2 = Portada.FileName;
                        fileName2 = Path.GetFileName(fileName2);
                        string directorio2 = Path.Combine("wwwroot\\images", nombre, "Portada");

                        if (!Directory.Exists(directorio2))
                        {
                            Directory.CreateDirectory(directorio2);
                        }

                        string uploadpath2 = Path.Combine("wwwroot\\images", nombre, "Portada", fileName2);
                        var stream2 = new FileStream(uploadpath2, FileMode.Create);
                        string path2 = ruta + "images/" + nombre + "/" + "Portada/" + fileName2;
                        _ = Portada.CopyToAsync(stream2);
						Cursos.Logo = path;
						Cursos.Portada = path2;
						Cursos.FechaActualizacion = DateTime.Now;
                        _context.Update(Cursos);
                        await _context.SaveChangesAsync();
                    }

					Cursos.FechaIngreso = Cursos.FechaIngreso;
					Cursos.Logo = Cursos.Logo;
					Cursos.Portada = Cursos.Portada;
					Cursos.FechaActualizacion = DateTime.Now;
                    _context.Update(Cursos);
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!CursosExists(Cursos.Id))
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

            ViewData["ComunaID"] = new SelectList(_context.Comuna.OrderBy(item => item.Nombre), "Id", "Nombre", Comuna.ComunaID);

            return View(Cursos);
        }

        [Authorize(Policy = "Admin")]
        private async Task<bool> UploadFile(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                return true;
            }
            return false;
        }

        [Authorize(Policy = "Admin")]
        private bool CursosExists(Guid Id)
        {
            return _context.Cursos.Any(e => e.Id == Id);
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeleteCursos(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Cursos = await _context.Cursos.Include(s => s.Comuna).SingleOrDefaultAsync(m => m.Id == Id);
            if (Cursos == null)
            {
                return NotFound();
            }

            ViewData["ComunaID"] = new SelectList(_context.Comuna.OrderBy(item => item.Nombre), "Id", "Nombre", Cursos.ComunaID);

            return View(Cursos);
        }

        [Authorize(Policy = "Admin")]
        [HttpPost, ActionName("DeleteCursos")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid Id)
        {
            var Cursos = await _context.Cursos.SingleOrDefaultAsync(m => m.Id == Id);
            _context.Cursos.Remove(Cursos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DetailsCursos(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var Cursos = await _context.Cursos.Include(s => s.Comuna).SingleOrDefaultAsync(m => m.Id == Id);
            if (Cursos == null)
            {
                return NotFound();
            }

            ViewData["ComunaID"] = new SelectList(_context.Comuna.OrderBy(item => item.Nombre), "Id", "Nombre", Cursos.ComunaID);

            return View(Cursos);
        }

        public async Task<IActionResult> Inscripcion(Guid id, [Bind("Id,UserID,UserMail,UserNombre,UserTelefono,UserRut,CursosID,Fecha,Estado")] Inscripcion Inscripcion)
        {
            var user = _userManager.Users.FirstOrDefault(u => u.Id == _userManager.GetUserId(User));
            var idUsuario = user.Id;
            var mailUsuario = user.Email;
            var NombreUsuario = user.Nombre + " " + user.Apellido;
            var telefonoUsuario = user.PhoneNumber;
            var rutUsuario = user.Rut;

            if (ModelState.IsValid)
            {
                try
                {
                    Inscripcion.Id = Guid.NewGuid();
                    Inscripcion.CursosID = id;
                    Inscripcion.UserID = idUsuario;
                    Inscripcion.UserMail = mailUsuario;
                    Inscripcion.UserNombre = NombreUsuario;
                    Inscripcion.UserTelefono = telefonoUsuario;
                    Inscripcion.UserRut = rutUsuario;
                    Inscripcion.Fecha = DateTime.Now;
                    Inscripcion.Estado = true;
                    _context.Add(Inscripcion);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Cursos));
                }

                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Cursos));
        }

        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> Solicitudes()
        {
            var applicationDbContext = _context.Inscripcion.Include(s => s.Cursos).Include(s => s.Cursos.Comuna);
            return View(await applicationDbContext.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}