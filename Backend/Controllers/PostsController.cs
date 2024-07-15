using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.DTOs;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostsService _titlesService;

        public PostsController(IPostsService titlesService)
        {
            _titlesService = titlesService;
        }

        [HttpGet]
        public async Task<IEnumerable<PostDto>> Get() =>
            await _titlesService.Get();
    }
}
