using AutoMapper;
using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.Core.Services;
using BilgeadamEgitim.WebAPI.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeadamEgitim.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {

        private readonly IContentService _contentService;
        private readonly IMapper _mapper;

        public ContentController(IContentService contentService, IMapper mapper)
        {
            this._contentService = contentService;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Content>> CreateContent(ContentDTO saveContent)
        {

            var content = _mapper.Map<Content>(saveContent);
            var savedContent = await _contentService.CreateContent(content);

            return Ok(saveContent);
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ContentResponseDTO>>> GetAllContents()
        {
            var contents = await _contentService.GetAllContents();
            var contentResources = _mapper.Map<IEnumerable<ContentResponseDTO>>(contents);
            
            //var contentsDto = contents.Select(x => new ContentDTO
            //{
            //    Id = x.Id,
            //    Body = x.Body,
            //    Title = x.Title
            //});
            return Ok(contentResources);
        }
    }
}
