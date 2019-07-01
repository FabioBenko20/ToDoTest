using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TodoList.Models
{
    public interface ILogin
    {
        
    }

    public class Login: ILogin
    {
        public int Id { get; set; }

        public string AccessToken { get; set; }

        
        public string UserAccess { get; set; }

        
        public string Password { get; set; }

        public string Name { get; set; }
    }
}
