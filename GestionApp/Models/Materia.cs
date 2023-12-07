using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionEscolarApp.Models
{
    public class Materia
    {

        [Display(Name = "Id Materia")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(45, MinimumLength = 2)]
        [Required]
        public string? NombreMateria { get; set; }

    }
}
