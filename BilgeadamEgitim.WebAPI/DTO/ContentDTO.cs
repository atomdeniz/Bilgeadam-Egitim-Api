using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeadamEgitim.WebAPI.DTO
{
    public class ContentDTO
    {
        [Required]
        public string Body { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
