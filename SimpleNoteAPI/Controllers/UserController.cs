using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleNoteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SingIn()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SingUp()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SingOut()
        {
            return Ok();
        }
    }
}
