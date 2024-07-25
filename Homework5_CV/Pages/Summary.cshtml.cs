using Homework5_CV.Models;
using Homework5_CV.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework5_CV.Pages
{
    public class SummaryModel : PageModel
    {

        private CVServices _cvServices;
        public DataModel CV { get; set; }

        public SummaryModel(CVServices cvServices)
        {
            _cvServices = cvServices;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            CV = await _cvServices.GetCVById(id);
            return Page();
        }
    }
}
