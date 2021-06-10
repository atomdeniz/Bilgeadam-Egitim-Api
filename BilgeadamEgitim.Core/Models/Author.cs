using BilgeadamEgitim.Core.Models.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace BilgeadamEgitim.Core.Models
{
    public class Author : BaseEntity
    {

        public Author()
        {
            Contents = new Collection<Content>();
        }


        [MaxLength(20)]
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Content> Contents { get; set; }

      
    }


    
}
