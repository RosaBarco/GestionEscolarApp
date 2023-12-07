using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionApp.Data;
using GestionEscolarApp.Models;

namespace GestionApp.Pages.Materias
{
    public class IndexModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public IndexModel(GestionApp.Data.GestionAppContext context)
        {
            _context = context;
        }

        public IList<Materia> Materia { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Materia = await _context.Materia.ToListAsync();
        }
    }
}
