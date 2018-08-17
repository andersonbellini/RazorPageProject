using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProjPages.Pages
{
    public class ContactModel : PageModel
    {

        [TempData]
        public String Nome { get; set; }

        public string Message { get; set; }

        public void OnGet(int id, int pg)
        {
            Message = "O número da página é: " + id.ToString() + " Página: " + pg.ToString();
        }
    }
}
