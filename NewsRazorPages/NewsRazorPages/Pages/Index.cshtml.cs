using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsRazorPages.Models;

namespace NewsRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]

        public AppNew Heading { get; set; }
        public string SubHeading { get; set; }

        public void OnGet()
        {
            this.Heading = new AppNew();
            this.Heading.Title = "News Razor Page!!!";
            this.Heading.ImgURL = "Img/hinh-nen-naruto-dep-nhat-2.jpg";
            this.Heading.Content = "Mood spoiled this to in any basked by ear as from counsel as power long dwelt flash caught he native";
            this.Heading.Description = "Time loathed tis talethis run one reverie did alone say";
        }

        public void OnPost()
        {
            this.SubHeading = "Titel";
        }
    }
}
