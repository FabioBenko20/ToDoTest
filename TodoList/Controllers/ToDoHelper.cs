using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Helpers.Interfaces;
using TodoList.Interfaces;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class ToDoHelper: IToDoHelper
    {
        private readonly IToDoService _toDoService;

        public ToDoHelper(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        public async Task<List<ToDo>> GetAll()
        {
            return await _toDoService.GetAll();
        }

        public async Task<ToDo> GetById(int id)
        {
            return await _toDoService.GetById(id);
        }

        public async Task<bool> Post(ToDo task)
        {
            return await _toDoService.PostTask(task);
        }

        public async Task<bool> Delete(int id)
        {
            return await _toDoService.DeleteTask(id);
        }
    }
}
