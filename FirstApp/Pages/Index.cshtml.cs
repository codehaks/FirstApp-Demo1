using FirstApp.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationState _state;
        public IndexModel(ILogger<IndexModel> logger, ApplicationState state)
        {
            _logger = logger;
            _state = state;
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
            //TempData["area"] = area;
            _state.Set("area",area.ToString());
            return RedirectToPage("./result");
        }
    }
}