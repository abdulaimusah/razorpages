
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using website.Services;

namespace website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiService;

        public IndexModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        public List<Item> Items { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Items = await _apiService.GetAllItems();
            return Page();
        }
    }
}
