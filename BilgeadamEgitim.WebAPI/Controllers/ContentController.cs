using AutoMapper;
using BilgeadamEgitim.Common.DTO;
using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.Core.Services;
using BilgeadamEgitim.WebAPI.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

            return Ok(contentResources);
        }

        [HttpGet("{id}")]
        [ValidateModel]
        public async Task<ActionResult<ContentResponseDTO>> GetContentById(int id)
        {
            var content = await _contentService.GetContentById(id);
            var contentResource = _mapper.Map<ContentResponseDTO>(content);
            return Ok(contentResource);
        }

        [HttpPut("{id}")]
        [ValidateModel]
        public async Task<ActionResult<ContentResponseDTO>> UpdateContent(int id, ContentDTO saveContent)
        {
            var contentToBeUpdated = await _contentService.GetContentById(id);
            if (contentToBeUpdated == null)
            {
                return NotFound();
            }
            var contentResource = _mapper.Map<Content>(saveContent);
            await _contentService.UpdateContent(contentToBeUpdated, contentResource);

            var contentResponse= _mapper.Map<ContentResponseDTO>(contentToBeUpdated);

            return Ok(contentResponse);
        }

        [HttpDelete("{id}")]
        [ValidateModel]
        public async Task<ActionResult<ContentResponseDTO>> DeleteContent(int id)
        {

            var contentToBeUpdated = await _contentService.GetContentById(id);
            if (contentToBeUpdated == null)
            {
                return NotFound();
            }

            await _contentService.DeleteContent(id);
            return NoContent();
           
        }
    }
}
