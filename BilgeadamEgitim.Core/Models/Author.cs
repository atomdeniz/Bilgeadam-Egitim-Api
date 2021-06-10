using BilgeadamEgitim.Core.Models.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BilgeadamEgitim.Core.Models
{
    public class Author : BaseEntity
    {

        public Author()
        {
            Contents = new Collection<Content>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Content> Contents { get; set; }

      
    }


    
}
