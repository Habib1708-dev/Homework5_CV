using Homework5_CV.Models;
using Homework5_CV.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Homework5_CV.Pages
{
    public class AllModel : PageModel
    {
        private readonly CVServices _cvServices;
        public List<DataModel> CVs { get; set; }

        public AllModel(CVServices cvServices)
        {
            _cvServices = cvServices;
        }
        public async Task OnGetAsync()
        {
            CVs= await _cvServices.GetAllCVs();
        }
    }
}
