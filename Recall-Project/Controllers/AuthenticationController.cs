using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recall_Project.Services;

namespace Recall_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public AuthencationService _service;
        public AuthenticationController(AuthencationService service)
        {
            _service = service;
        }
        [HttpGet("GetToken")]
        public string GetToken()
        {
            return _service.GenerateToken();
        }
    }
}
