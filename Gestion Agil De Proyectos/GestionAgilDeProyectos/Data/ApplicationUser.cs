using Microsoft.AspNetCore.Identity;
using System;

namespace GestionAgilDeProyectos.Data
{
	public class ApplicationUser : IdentityUser
	{
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Rut { get; set; }
		public string FechaNacimiento { get; set; }
		public bool Terms { get; set; }
	}
}