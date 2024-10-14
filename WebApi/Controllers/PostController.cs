using Microsoft.AspNetCore.Mvc;
using Shared;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly ILogger<PostController> _logger;
        private static List<Post> _posts = new();

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _posts;
        }

        [HttpPost]
        public void Post(Post post) 
        {
            _posts.Add(post);
            _logger.LogInformation("Added {post}", post);
        }
    }
}
