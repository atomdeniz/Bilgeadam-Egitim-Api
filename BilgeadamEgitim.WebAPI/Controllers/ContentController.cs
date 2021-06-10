using BilgeadamEgitim.Core.Models;
using BilgeadamEgitim.Core.Services;
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
        public ContentController(IContentService contentService)
        {
            this._contentService = contentService;
        }

        [HttpPost]
        public async Task<ActionResult<Content>> CreateContent(Content saveContent)
        {
            saveContent.CreatedDate = DateTime.Now;
            saveContent.UpdatedDate = DateTime.Now;
            saveContent.IsDeleted = false;

            var savedContent = await _contentService.CreateContent(saveContent);

            return Ok(saveContent);
        }
    }
}
