using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Helpers;
using TodoList.Helpers.Interfaces;
using TodoList.Interfaces;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class UserHelper : IUserHelper
    {
        private readonly ILoginService _authorizationService;

        public UserHelper(ILoginService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        public async Task<Login> GetUserAuthentication(Login loginDetails)
        {
            try
            {
                if (loginDetails == null)
                {
                    throw new ArgumentNullException("Invalid Login Object");
                }


                return await _authorizationService.GetUserInformation(loginDetails);
            }
            catch (Exception error)
            {
                throw new ArgumentNullException(error.Message.ToString());
            }

        }
    }
}
