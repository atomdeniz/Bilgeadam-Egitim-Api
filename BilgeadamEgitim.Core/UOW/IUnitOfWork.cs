using BilgeadamEgitim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BilgeadamEgitim.Core.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        IContentRepository Contents { get; }

        Task<int> CommitAsync();
    }
}
