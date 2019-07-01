using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Helpers.Interfaces
{
    public interface IJwtHelper
    {
        Task<Login> GenerateToken(Login login);
    }

    
}
