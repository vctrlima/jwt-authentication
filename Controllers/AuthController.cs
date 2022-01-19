using JWT.Authentication.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Authentication.Api.Controllers
{
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }
    }
}