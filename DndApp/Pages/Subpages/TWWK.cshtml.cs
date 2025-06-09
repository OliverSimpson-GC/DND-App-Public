using DndApp.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DndApp.Pages.Subpages
{
    public class TWWKModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public TWWKModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Background"] = "../Images/TWWK/TWWK Art.jpg";
        }
    }
}
