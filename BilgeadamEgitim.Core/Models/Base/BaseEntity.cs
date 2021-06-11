using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.Core.Models.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDate
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }

        private DateTime? dateCreated = null;


        public DateTime UpdatedDate
        {
            get
            {
                return this.dateUpdated.HasValue
                   ? this.dateUpdated.Value
                   : DateTime.Now;
            }

            set { this.dateUpdated = value; }
        }

        private DateTime? dateUpdated = null;


        public bool IsDeleted { get; set; }

    }
}
