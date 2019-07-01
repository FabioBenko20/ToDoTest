using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoList.Interfaces;
using TodoList.Models;

namespace TodoList.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserHelper _userHelper;

        public UserController(IUserHelper userHelper)
        {
            _userHelper = userHelper;
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<Login>> AuthenticateLogIn([FromBody] Login loginDetails )
        {
            if (loginDetails == null)
                return BadRequest(new { message = "Username or password is incorrect!" });


            return await _userHelper.GetUserAuthentication(loginDetails);
        }


    }
}