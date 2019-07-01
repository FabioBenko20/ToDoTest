using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Helpers.Interfaces
{
    public interface IToDoService
    {
        Task<List<ToDo>> GetAll();

        Task<ToDo> GetById(int Id);

        Task<bool> PostTask(ToDo task);

        Task<bool> DeleteTask(int Id);
    }
}
