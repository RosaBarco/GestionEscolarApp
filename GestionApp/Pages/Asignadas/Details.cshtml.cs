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
    public class DetailsModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public DetailsModel(GestionApp.Data.GestionAppContext context)
        {
            _context = context;
        }

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
    }
}
