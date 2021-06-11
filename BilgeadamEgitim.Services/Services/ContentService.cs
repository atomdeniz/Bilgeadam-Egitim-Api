using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.Core.Services;
using BilgeadamEgitim.Core.UOW;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BilgeadamEgitim.Services.Services
{
    public class ContentService : IContentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Content> CreateContent(Content newContent)
        {
            await _unitOfWork.Contents.AddAsync(newContent);
            await _unitOfWork.CommitAsync();


            return newContent;
        }


        public async Task<IEnumerable<Content>> GetAllContents()
        {
            var contents = await _unitOfWork.Contents.GetAllAsync();

            return contents;
        }

        public async Task<Content> GetContentById(int id)
        {
            return await _unitOfWork.Contents.GetByIdAsync(id);
        }


        public async Task UpdateContent(Content contentToBeUpdated, Content content)
        {
            contentToBeUpdated.Title = content.Title;
            contentToBeUpdated.Body = content.Body;
            await _unitOfWork.CommitAsync();
        }


        public async Task DeleteContent(int id)
        {
            var willDeleted = await _unitOfWork.Contents.GetByIdAsync(id);
            _unitOfWork.Contents.Remove(willDeleted);
            await _unitOfWork.CommitAsync();
        }
    }
}
