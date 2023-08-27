using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class UserContextController : ControllerBase
    {
        private readonly ContextService _userContextService;

        public UserContextController(ContextService userContextService)
        {
            _userContextService = userContextService;
        }

        [HttpGet("userContext")]
        public IActionResult UserEndpoint()
        {
            var userId = 123;
            var data = _userContextService.GetUserContextData(userId);
            return Ok(data);
        }
    }
}
