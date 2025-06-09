using DndApp.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DndApp.Pages.Subpages
{
    public class LunaCModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public LunaCModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Background"] = "../Images/LunaC/Luna C art.jpg";
        }
    }
}
