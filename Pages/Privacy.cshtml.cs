using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace resume_ui.Pages;

public class PrivacyModel : PageModel
{
   public String full_name {get; set;}
   public String job_Title {get; set;}
   public String email {get; set;}
   public String adddress_user {get; set;}
    public void OnGet()
    {
         full_name     = "Ramy";
            job_Title     = "Student of IT department";
            email         = "030805ramy@gmail.com";
           
            adddress_user = "Phnom Penh, Cambodia";
                      

    }
}

