using System;
using System.ComponentModel.DataAnnotations;

namespace GestionAgilDeProyectos.Models
{
    public class Region
    {
        public static object RegionID { get; internal set; }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nombre Region")]
        public string Nombre { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaIngreso { get; set; }

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaActualizacion { get; set; }

    }
}
