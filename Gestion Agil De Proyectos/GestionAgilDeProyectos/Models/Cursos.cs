using System;
using System.ComponentModel.DataAnnotations;

namespace GestionAgilDeProyectos.Models
{
    public class Cursos
	{
        public static object CursosID { get; internal set; }

        [Key]
        public Guid Id { get; set; }

		[Required(ErrorMessage = "*Debes ingresar la Comuna")]
		[Display(Name = "Comuna")]
		public Guid ComunaID { get; set; }
		public Comuna Comuna { get; set; }

        [Required(ErrorMessage = "*Debes ingresar el Nombre")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "*Debes ingresar la Direccion")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "*Debes ingresar la Descripcion")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name = "Logo Curso")]
        public string Logo { get; set; }

        [Display(Name = "Portada Curso")]
        public string Portada { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "*Debes ingresar la Fecha de Curso")]
        [Display(Name = "Fecha inicio Publicación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaCurso { get; set; }

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaActualizacion { get; set; }

		[DisplayFormat(DataFormatString = "{0:C0}")]
		[Required(ErrorMessage = "*Debes ingresar el Valor")]
		[Display(Name = "Valor en Pesos")]
		public int ValorPeso { get; set; }

        public string Estado { get; set; }
    }
}