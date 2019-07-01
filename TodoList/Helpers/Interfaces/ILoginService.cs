using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Helpers.Interfaces
{
    public interface ILoginService
    {
        Task<Login> GetUserInformation(Login loginDetails);
    }
}
