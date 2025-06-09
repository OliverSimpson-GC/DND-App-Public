using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DndApp.Pages.Subpages
{
    public class FLModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public FLModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Background"] = "../Images/FL/Fallen Background.png";
        }
    }
}
