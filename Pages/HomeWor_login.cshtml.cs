using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace resume_ui.Pages ;
    public class HomeWor_loginModel : PageModel
    {
        [BindProperty]
        public string InputUsername { get; set; }

        [BindProperty]
        public string InputPassword { get; set; }

        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }

      
        private readonly List<User> _fakeDatabase = new List<User>
        {
            new User { Username = "admin", Password = "123" }
        };

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var foundUser = _fakeDatabase.FirstOrDefault(u => 
                u.Username == InputUsername && 
                u.Password == InputPassword);

            if (foundUser != null)
            {
                SuccessMessage = "Login successful!";
                return Page();
            }
            
            ErrorMessage = "Invalid username or password.";
            return Page();
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
