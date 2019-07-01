using Microsoft.AspNetCore.Authorization;

using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

using System.Threading.Tasks;
using TodoList.Helpers.Interfaces;
using TodoList.Models;

namespace TodoList.Helpers
{
    public class LoginService : ILoginService
    {
        private readonly IJwtHelper _jwtHelper;

        public LoginService(IJwtHelper jwtHelper)
        {
            _jwtHelper = jwtHelper;
        }
               
        List<Login> logins = new List<Login>();
        
               
        private List<Login> GenerateUser()
        {

            Login login1 = new Login { Id = 1, Name = "Eoghan", UserAccess = "test", Password = "pws123" };
            Login login2 = new Login { Id = 2, Name = "Mary", UserAccess = "test2", Password = "pws2" };
            Login login3 = new Login { Id = 3, Name = "John", UserAccess = "test3", Password = "pws3" };
            logins.Add(login1);
            logins.Add(login2);
            logins.Add(login3);




            return logins;
        }

        public async Task<Login> GetUserInformation(Login loginDetails)
        {
            //Generate login info simulating DB;
            Login login = GenerateUser().Where(u => u.UserAccess == loginDetails.UserAccess &&
                                            u.Password == loginDetails.Password).FirstOrDefault();

            login.Password = "";

            if (login == null)
            {
                return null;
            }
            return await _jwtHelper.GenerateToken(login);
        }


    }
}
