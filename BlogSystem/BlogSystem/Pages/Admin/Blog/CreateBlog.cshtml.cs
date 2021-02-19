using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogSystem.Pages
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]
        public Blog Blog { get; set; } = new Blog();

        private List<Author> Authors { get; set; } = new List<Author>();

        public IEnumerable<SelectListItem> AuthorList { get; private set; }
        public string GivenName { get; private set; }
        public string Email { get; private set; }


        public CreateBlogModel()
        {
            Author a = new Author()
            {
                GivenName = "Leonard",
                LastName = "Hofstadter",
                Birthdate = "19800517",
                EmailAddress = "leonard.hofstadter@cambriancollege.ca",
                WebsiteAddress = "https://leonard.ca/",
                PhoneNumber = "6473458736",
                Country = "Canada",
                Province = "Ontario",
                PostalCode = "M3C1K1",
            };

            Author b = new Author()
            {
                GivenName = "Sheldon",
                LastName = "Cooper",
                Birthdate = "19800226",
                EmailAddress = "sheldon.cooper@cambriancollege.ca",
                WebsiteAddress = "https://sheldon.ca/",
                PhoneNumber = "6475438736",
                Country = "Canada",
                Province = "Ontario",
                PostalCode = "M3C1K1",
            };

            Author c = new Author()
            {
                GivenName = "Howard",
                LastName = "Wolowitz",
                Birthdate = "19810930",
                EmailAddress = "howard.wolowitz@cambriancollege.ca",
                WebsiteAddress = "https://howard.ca/",
                PhoneNumber = "6474538736",
                Country = "Canada",
                Province = "Ontario",
                PostalCode = "M3C1K1",
            };
            Authors.Add(a);
            Authors.Add(b);
            Authors.Add(c);

        }
        public void OnGet()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var auth in Authors)
            {
                list.Add(new SelectListItem(auth.GivenName, auth.EmailAddress));
            }

            AuthorList = list;
        }

        public void OnPost()
        {
        }
    }
}
