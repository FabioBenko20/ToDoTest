using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Interfaces
{
    public interface IUserHelper
    {
        Task<Login> GetUserAuthentication(Login loginDetails);
    }
}
