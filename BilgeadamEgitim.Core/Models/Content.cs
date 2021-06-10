using BilgeadamEgitim.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.Core.Models
{
    public class Content : BaseEntity
    {
        public string Body { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
