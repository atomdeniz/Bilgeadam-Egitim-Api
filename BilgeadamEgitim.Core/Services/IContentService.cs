using BilgeadamEgitim.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BilgeadamEgitim.Core.Services
{
    public interface IContentService
    {
        Task<Content> CreateContent(Content newContent);

        Task<IEnumerable<Content>> GetAllContents();

        Task<Content> GetContentById(int id);

        Task UpdateContent(Content contentToBeUpdated, Content content);

        Task DeleteContent(int id);


    }
}
