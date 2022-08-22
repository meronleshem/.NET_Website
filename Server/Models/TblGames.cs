using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestASP.Models
{
    public class TblGames
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Time { get; set; }
        public DateTime Date { get; set; }
    }
}
