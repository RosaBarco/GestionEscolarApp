using System.ComponentModel.DataAnnotations;

namespace GestionEscolarApp.Models
{
    public class Asignada
    {
        [Display(Name = "Id Asignadas")]
        public int Id { get; set; }

        [Display(Name = "Id Materia")]
        public int IdMateria { get; set; }

        [Display(Name = "Id Profesor")]
        public int IdProfesor { get; set; }

        [Display(Name = "Horario")]
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Horario { get; set; }

        [Display(Name = "Salón")]
        [StringLength(40, MinimumLength = 2)]
        [Required]
        public string? Salon { get; set; }


    }
}
