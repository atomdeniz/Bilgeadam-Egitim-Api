using BilgeadamEgitim.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BilgeadamEgitim.Core.Services
{
    public interface IContentService
    {
        Task<IEnumerable<Content>> GetAllContents();
    }
}
