using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestASP.Data;
using TestASP.Models;

namespace TestASP.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly TestASP.Data.TestASPContext _context;

        public IndexModel(TestASP.Data.TestASPContext context)
        {
            _context = context;
        }

        public IList<TblGames> TblGames { get;set; }

        public async Task OnGetAsync()
        {
            TblGames = await _context.TblGames.ToListAsync();
        }
    }
}
