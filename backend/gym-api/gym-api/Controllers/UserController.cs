using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gym_api.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController() { }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromQuery] string RequestSource, int id)
        {
            return Ok("User info");
        }


        [Authorize(Roles = "EnterpriseUser")]
        [HttpPost]
        public IActionResult CreateUser()
        {
            return Ok("Creating user");
        }


    }

}
