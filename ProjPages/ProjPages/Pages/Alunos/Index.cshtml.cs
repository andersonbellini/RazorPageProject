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
    public class IndexModel : PageModel
    {
        private readonly ProjPages.Models.ApplicationDbContext _context;

        public IndexModel(ProjPages.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Alunos> Alunos { get;set; }

        public async Task OnGetAsync()
        {
            Alunos = await _context.Alunos.ToListAsync();
        }
    }
}
