using DndApp.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DndApp.Pages.Subpages
{
    public class SSModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public SSModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Background"] = "../Images/SS/Port of the Khans.jpg";
        }
    }
}
