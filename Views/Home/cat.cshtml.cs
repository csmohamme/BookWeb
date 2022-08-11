using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace bookWeb.Views.Home
{
    public class cat : PageModel
    {
        private readonly ILogger<cat> _logger;

        public cat(ILogger<cat> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}