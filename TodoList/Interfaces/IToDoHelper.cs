using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Interfaces
{
    public interface IToDoHelper
    {
        Task<List<ToDo>> GetAll();


        Task<ToDo> GetById(int id);


        Task<bool> Post(ToDo task);


        Task<bool> Delete(int id);


    }
}
