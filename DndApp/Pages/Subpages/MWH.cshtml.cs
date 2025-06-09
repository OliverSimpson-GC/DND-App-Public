using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DndApp.Pages.Subpages
{
    public class MWHModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public MWHModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Background"] = "../Images/MWH/Current map.png";
        }
    }
}
