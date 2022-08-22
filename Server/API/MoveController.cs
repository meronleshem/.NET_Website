using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestASP.Models;

namespace TestASP.API
{
    [Route("api/move")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        // GET: api/TblGames/5
        [HttpGet("{num}")]
        public async Task<ActionResult<ComputerMove>> GetMove(int num)
        {
            Random rnd = new Random();
            int move = rnd.Next(0, num);

            return new ComputerMove(move);
        }

    }
}
