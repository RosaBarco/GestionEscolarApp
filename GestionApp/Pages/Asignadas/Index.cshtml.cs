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
    public class IndexModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public IndexModel(GestionApp.Data.GestionAppContext context)
        {
            _context = context;
        }

        public IList<Asignada> Asignada { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Asignada = await _context.Asignada.ToListAsync();
        }
    }
}
