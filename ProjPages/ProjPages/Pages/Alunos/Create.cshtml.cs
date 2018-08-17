using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjPages.Models;

namespace ProjPages.Pages.Alunos
{
    public class CreateModel : PageModel
    {
        private readonly ProjPages.Models.ApplicationDbContext _context;

        public CreateModel(ProjPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Alunos Alunos { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Alunos.Add(Alunos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}