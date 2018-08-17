using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjPages.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Pessoa pessoa { get; set; }

        [BindProperty]
        public Cidades cidades { get; set; }

        [TempData]
        public String Nome { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string param1)
        {
            Nome = param1;
            return RedirectToPage("Contact");
        }

        public void OnPostPessoa()
        {
            
        }


        public void OnPostPessoaCidade()
        {

        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }


    public class Cidades
    {
        public int Id { get; set; }
        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
