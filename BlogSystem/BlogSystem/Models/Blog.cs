using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class Blog
    {
        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        public Author Author { get; set; }

        [DataType(DataType.Date)]
        public string PublishDate { get; set; }

    }
}
