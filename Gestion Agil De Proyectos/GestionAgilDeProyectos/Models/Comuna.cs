using System;
using System.ComponentModel.DataAnnotations;

namespace GestionAgilDeProyectos.Models
{
    public class Comuna
    {
        public static object ComunaID { get; internal set; }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "*Debes Seleccionar la Provincia")]
        [Display(Name = "Provincia")]
        public Guid ProvinciaID { get; set; }
        public Provincia Provincia { get; set; }

        [Display(Name = "Nombre Comuna")]
        public string Nombre { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaIngreso { get; set; }

        [Display(Name = "Fecha de Actualizacion")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime FechaActualizacion { get; set; }

    }
}
