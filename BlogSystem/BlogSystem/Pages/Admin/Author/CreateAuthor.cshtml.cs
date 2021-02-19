using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogSystem.Models;

namespace BlogSystem.Pages
{
    public class CreateAuthorModel : PageModel
    {
        public void OnPost()
        {
        }

        [FromForm]
        public Author Author { get; set; } = new Author();
    }
}
