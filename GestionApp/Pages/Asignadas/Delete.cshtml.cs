using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;

namespace GestionApp.Pages.Asignadas
{
    public class DeleteModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public DeleteModel(GestionApp.Data.GestionAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Asignada Asignada { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignada = await _context.Asignada.FirstOrDefaultAsync(m => m.Id == id);

            if (asignada == null)
            {
                return NotFound();
            }
            else
            {
                Asignada = asignada;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asignada = await _context.Asignada.FindAsync(id);
            if (asignada != null)
            {
                Asignada = asignada;
                _context.Asignada.Remove(Asignada);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
