using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstApp.Pages
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
            Length = 9;
            Width = 5;
        }

        [BindProperty]
        public int Length { get; set; }

        [BindProperty]
        public int Width { get; set; }

        public IActionResult OnPost()
        {
            var area = Length * Width;
            TempData["area"] = area;
            return RedirectToPage("./result");
        }
    }
}