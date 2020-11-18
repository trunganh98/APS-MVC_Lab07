using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsRazorPages.Models
{
    public class AppNew
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImgURL { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
    }
}
