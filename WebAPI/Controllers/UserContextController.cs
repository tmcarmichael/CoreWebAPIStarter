using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class UserContextController : ControllerBase
    {
        private readonly IContextService _userContextService;

        public UserContextController(IContextService userContextService)
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
