using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;

namespace GestionApp.Pages.Calificaciones
{
    public class DeleteModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public DeleteModel(GestionApp.Data.GestionAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Calificacion Calificacion { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion.FirstOrDefaultAsync(m => m.Id == id);

            if (calificacion == null)
            {
                return NotFound();
            }
            else
            {
                Calificacion = calificacion;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var calificacion = await _context.Calificacion.FindAsync(id);
            if (calificacion != null)
            {
                Calificacion = calificacion;
                _context.Calificacion.Remove(Calificacion);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
