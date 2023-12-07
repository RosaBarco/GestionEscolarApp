using System.ComponentModel.DataAnnotations;

namespace GestionApp.Models
{
    public class Alumno
    {
        [Display(Name = "Id Alumno")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(45, MinimumLength = 2)]
        [Required]
        public string? NombreAlumno { get; set; }

        [Display(Name = "Apellido Materno")]
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? ApellidoAlumno { get; set; }

        [Display(Name = "Matricula")]
        [Range(10000000, 99999999)]
        [Required]
        public int MatriculaAlumno { get; set; }
    }
}
