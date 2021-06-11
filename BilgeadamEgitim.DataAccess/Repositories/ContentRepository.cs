using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.DataAccess;
using BilgeadamEgitim.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.Core.Repositories
{
    public class ContentRepository : Repository<Content>, IContentRepository
    {
        public ContentRepository(BlogDbContext context) : base(context)
        {

        }


        private BlogDbContext BlogDbContext
        {
            get { return Context as BlogDbContext; }
        }
    }
}
