using System.ComponentModel.DataAnnotations;

namespace GestionEscolarApp.Models
{
    public class Calificacion
    {

        [Display(Name = "Id Calificación")]
        public int Id { get; set; }

        [Display(Name = "Id Materia")]
        public int IdMateria { get; set; }

        [Display(Name = "Id Alumno")]
        public int IdAlumno { get; set; }

        [Display(Name = "Calificación")]
        [Range(0, 100)]
        [Required]
        public int nota { get; set; }

    }
}
