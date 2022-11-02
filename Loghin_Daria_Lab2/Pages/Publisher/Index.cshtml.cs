using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghin_Daria_Lab2.Data;
using Loghin_Daria_Lab2.Models;

namespace Loghin_Daria_Lab2.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Loghin_Daria_Lab2.Data.Loghin_Daria_Lab2Context _context;

        public IndexModel(Loghin_Daria_Lab2.Data.Loghin_Daria_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
