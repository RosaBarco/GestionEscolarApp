using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;

namespace GestionApp.Pages.Asignadas
{
    public class EditModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public EditModel(GestionApp.Data.GestionAppContext context)
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

            var asignada =  await _context.Asignada.FirstOrDefaultAsync(m => m.Id == id);
            if (asignada == null)
            {
                return NotFound();
            }
            Asignada = asignada;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Asignada).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsignadaExists(Asignada.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AsignadaExists(int id)
        {
            return _context.Asignada.Any(e => e.Id == id);
        }
    }
}
