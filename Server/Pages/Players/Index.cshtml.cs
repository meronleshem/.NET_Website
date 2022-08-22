using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestASP.Data;
using TestASP.Models;

namespace TestASP.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly TestASP.Data.TestASPContext _context;

        public IndexModel(TestASP.Data.TestASPContext context)
        {
            _context = context;
        }

        public IList<TblPlayers> TblPlayers { get;set; }

        [BindProperty]
        public IList<TblGames> TblGames { get; set; }
        public IList<Query6> Query6 { get; set; }


        [BindProperty]
        public string Name{ get; set; }

        [BindProperty]
        public int Num { get; set; }

        public async Task OnGetAsync()
        {
            TblPlayers = await _context.TblPlayers.ToListAsync();
            TblGames = await _context.TblGames.ToListAsync();
        }
        public async Task OnPostQ1Async()
        {
            TblPlayers = await _context.TblPlayers.OrderBy(p => p.Name).ToListAsync();
        }
      

        public async Task OnPostQ2Async()
        {
            TblPlayers = await _context.TblPlayers.OrderByDescending(p =>p.Name, StringComparer.OrdinalIgnoreCase).ToListAsync();
        }
        public async Task OnPostQ3Async()
        {
            TblPlayers = await _context.TblPlayers.ToListAsync();
            TblGames = await _context.TblGames.ToListAsync();
        }
        public async Task OnPostQ4Async()
        {
            TblPlayers = await _context.TblPlayers.ToListAsync();
            var x = await _context.TblGames.ToListAsync();
            TblGames = x.Distinct(new MyCmp()).ToList();
        }

        public async Task OnPostQ5Async()
        {
            TblPlayers = await _context.TblPlayers.Where(p => p.Num == Num).ToListAsync();
            var playerId = TblPlayers.First().Id;
            TblGames = await _context.TblGames.Where(g => g.PlayerId == playerId).ToListAsync();
            TblPlayers = await _context.TblPlayers.ToListAsync();
        }
        public async Task OnPostQ6Async()
        {
            TblPlayers = await _context.TblPlayers.ToListAsync();
            var groups = from r in _context.TblGames
                         group r by r.PlayerId into grp
                         select new Query6 { PlayerId = grp.Key, GamesCount = grp.Count() };

            Query6 = await groups.ToListAsync();
            TblGames = await _context.TblGames.ToListAsync();

        }
        public async Task OnPostQ7Async()
        {
            TblPlayers = await _context.TblPlayers.ToListAsync();
            TblGames = await _context.TblGames.ToListAsync();
        }
    }

    class MyCmp : IEqualityComparer<TblGames>
    {
        public bool Equals(TblGames x, TblGames y)
        {
            return x.PlayerId == y.PlayerId;
        }

        public int GetHashCode(TblGames g)
        {
            return g.PlayerId.GetHashCode();
        }
    }
}
