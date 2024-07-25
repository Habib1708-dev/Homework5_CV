using Homework5_CV.Commands;
using Homework5_CV.Models;
using Homework5_CV.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Homework5_CV.Pages
{
    public class CVModel : PageModel
    {

        [BindProperty]
        public CVBindModel input { get; set; }
        public CVViewModel view { get; set; }

        private CVServices _cvServices { get; set; }
        public CVModel(CVServices cvServices)
        {
            _cvServices = cvServices;
        }
        
        public IEnumerable<SelectListItem> Nationalities { get; set; } = new List<SelectListItem>
            {
                new SelectListItem { Text = "USA", Value = "USA" },
                new SelectListItem { Text = "UK", Value = "UK" },
                new SelectListItem { Text = "Lebanon", Value = "Lebanon" },
                new SelectListItem { Text = "Canada", Value = "Canada" },
                new SelectListItem { Text = "France", Value = "France" }
            };

        public List<SelectListItem> SkillsList { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Java", Value = "Java" },
            new SelectListItem { Text = "Python", Value = "Python" },
            new SelectListItem { Text = "ASP", Value = "ASP" }
        };

        public void OnGet()
        {

        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if ( (input.Val1 + input.Val2) != input.Val3)
            {
                ModelState.AddModelError("","Val1 + Val2 must equal Val3");
            }

            if (!ModelState.IsValid)
            {

                Console.WriteLine("Input:");
                Console.WriteLine(input.FirstName.ToString());
                Console.WriteLine(input.LastName.ToString());
                Console.WriteLine(input.Birthday.ToString());
                Console.WriteLine(input.Nationality.ToString());
                Console.WriteLine(input.Sex.ToString());
                foreach (var skill in input.Skills)
                {
                    Console.WriteLine(skill);
                }
                Console.WriteLine(input.Email.ToString());
                Console.WriteLine(input.EmailConfirm.ToString());
                Console.WriteLine(input.Password.ToString());
                Console.WriteLine(input.Val1.ToString());
                Console.WriteLine(input.Val2.ToString());
                Console.WriteLine(input.Val3.ToString());
                Console.WriteLine(input.Photo.FileName);

                return Page();
            }

            Console.WriteLine("Input:");
            Console.WriteLine(input.FirstName.ToString());
            Console.WriteLine(input.LastName.ToString());
            Console.WriteLine(input.Birthday.ToString());
            Console.WriteLine(input.Nationality.ToString());
            Console.WriteLine(input.Sex.ToString());
            foreach (var skill in input.Skills)
            {
                Console.WriteLine(skill);
            }
            Console.WriteLine(input.Email.ToString());
            Console.WriteLine(input.EmailConfirm.ToString());
            Console.WriteLine(input.Password.ToString());
            Console.WriteLine(input.Val1.ToString());
            Console.WriteLine(input.Val2.ToString());
            Console.WriteLine(input.Val3.ToString());
            Console.WriteLine(input.Photo.FileName);

            var cvCommand = new CvCommand
            {
                FirstName = input.FirstName,
                LastName = input.LastName,
                Birthday = input.Birthday,
                Nationality = input.Nationality,
                Sex = input.Sex,
                Skills = input.Skills != null ? string.Join(",", input.Skills) : null,
                Email = input.Email,
                Password = input.Password,
                PhotoUrl = input.Photo.FileName 
            };

            int cvId=await _cvServices.addCV(cvCommand);

            return RedirectToPage("/Summary", new {id=cvId});
        }


    }
}
