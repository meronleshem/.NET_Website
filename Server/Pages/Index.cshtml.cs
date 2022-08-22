using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TestASP.Models;

namespace TestASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public Player Player { get; set; } 

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                string name = Player.Name;
                this.Response.WriteAsync("<p>" + name + "</p");
            }
        }
    }
}
