using DndApp.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace DndApp.Pages.Subpages
{
    public class CASOUModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public CASOUModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Background"] = "../Images/CASOU/Mission - The Ice Ship.jpg";
        }
    }
}
