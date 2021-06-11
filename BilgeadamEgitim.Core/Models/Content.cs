using BilgeadamEgitim.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BilgeadamEgitim.Core.Models
{
    public class Content : BaseEntity
    {
        public string Body { get; set; }
            
        [MaxLength(20)]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }


    }
}
