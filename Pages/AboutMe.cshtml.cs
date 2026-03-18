using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ExperienceItem
    {
        public string Role    { get; set; } = "";
        public string Company { get; set; } = "";
        public string Period  { get; set; } = "";
        public List<string> Bullets { get; set; } = new();
    }

    public class AboutMeModel : PageModel
    {
        public string? full_name     { get; set; }
        public string? job_Title     { get; set; }
        public string? adddress_user { get; set; }
        public string? phone_number  { get; set; }
        public string? email         { get; set; }
        public string? summary       { get; set; }
        public string? edu_degree    { get; set; }
        public string? edu_year      { get; set; }
        public string? edu_school    { get; set; }
        public List<string> skills { get; set; } = new();
        public List<ExperienceItem> experiences { get; set; } = new();

        public void OnGet()
        {
            full_name     = "Ramy";
            job_Title     = "IT";
            email         = "030805ramy@gmail.com";
            phone_number  = "069910033";
            adddress_user = "Phnom Penh, Cambodia";

            summary = "Motivated developer with experience in modern web technologies. " +
                      "Passionate about building responsive, user-friendly applications " +
                      "and solving complex problems with clean, maintainable code.";

            edu_degree = "";
            edu_year   = "";
                edu_school = "";

            skills = new List<string> { "C#", "ASP.NET Core", "HTML", "CSS", "JavaScript", "Git" };

            experiences = new List<ExperienceItem>
            {
                new ExperienceItem
                {
                    Role    = "Kak Developer",
                    Company = "Train IT support.",
                    Period  = "2025 - Present",
                    Bullets = new List<string>
                    {
                        "Built responsive web pages using Razor Pages and CSS Grid.",
                        "Managed database connections using SQL Server and Entity Framework.",
                        "Collaborated with design team to implement UI/UX improvements."
                    }
                }
            };
        }
    }
}