using System;
using System.ComponentModel.DataAnnotations;

namespace GestionAgilDeProyectos.Models
{
    public class Inscripcion
    {
        [Key]
        public Guid Id { get; set; }

        public Guid CursosID { get; set; }
        public Cursos Cursos { get; set; }

        public string UserID { get; set; }

        public string UserMail { get; set; }

        public string UserNombre { get; set; }

        public string UserTelefono { get; set; }

        public string UserRut { get; set; }

        public DateTime Fecha { get; set; }

        public bool Estado { get; set; }
    }
}