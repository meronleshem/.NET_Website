using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestASP.Models;

namespace TestASP.Data
{
    public class TestASPContext : DbContext
    {
        public TestASPContext (DbContextOptions<TestASPContext> options)
            : base(options)
        {
        }

        public DbSet<TestASP.Models.TblPlayers> TblPlayers { get; set; }

        public DbSet<TestASP.Models.TblGames> TblGames { get; set; }
    }
}
