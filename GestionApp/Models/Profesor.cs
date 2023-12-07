using System.ComponentModel.DataAnnotations;

namespace GestionApp.Models
{
    public class Profesor
    {
        [Display(Name = "Id Profesor")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(45, MinimumLength = 2)]
        [Required]
        public string? NombreProfesor { get; set; }

        [Display(Name = "Apellido Materno")]
        [StringLength(90, MinimumLength = 2)]
        [Required]
        public string? ApellidoProfesor { get; set; }

        [Display(Name = "Matricula")]
        [Range(10000000, 99999999)]
        [Required]
        public int MatriculaProfesor { get; set; }
    }
}
