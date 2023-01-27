using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Dto;

namespace Api.Controllers
{
    [Route("/Identity")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IidentityService _identityService;
        public IdentityController(IidentityService identityService)
        {
            _identityService = identityService;
        }
     
        [HttpPost("Login")]
        public async Task<string> Login([FromBody]LoginDto login)
        {
            try
            {
                var message = await _identityService.LoginService(login);
                return message;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
