using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjPages.Models;

namespace ProjPages.Pages.Alunos
{
    public class DetailsModel : PageModel
    {
        private readonly ProjPages.Models.ApplicationDbContext _context;

        public DetailsModel(ProjPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Alunos Alunos { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Alunos = await _context.Alunos.SingleOrDefaultAsync(m => m.id == id);

            if (Alunos == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
