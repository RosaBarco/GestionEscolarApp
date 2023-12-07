﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GestionApp.Data;
using GestionEscolarApp.Models;

namespace GestionApp.Pages.Asignadas
{
    public class CreateModel : PageModel
    {
        private readonly GestionApp.Data.GestionAppContext _context;

        public CreateModel(GestionApp.Data.GestionAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Asignada Asignada { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Asignada.Add(Asignada);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
