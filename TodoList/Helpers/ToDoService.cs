using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Helpers.Interfaces;
using TodoList.Models;

namespace TodoList.Helpers
{
    public class ToDoService : IToDoService
    {

        public async Task<List<ToDo>> GetAll()
        {
            List<ToDo> tasks = new List<ToDo>
            {
                new ToDo{  IdToDo =1,UserId = 1, CreationDate = System.DateTime.Now, Title = "Task One",  Description ="Display Task one",  Complete = false },
                 new ToDo{  IdToDo =2,UserId = 1, CreationDate = System.DateTime.Now, Title = "Task two",  Description ="Display Task two",  Complete = false }
            };

            return tasks;
        }

        public async Task<ToDo> GetById(int Id)
        {
            ToDo task = new ToDo { IdToDo = 1, UserId = 1, CreationDate = System.DateTime.Now, Title = "Task One", Description = "Display Task one", Complete = false };

            return task;
        }


        public async Task<bool> PostTask(ToDo task)
        {

            return true;
        }

        public async Task<bool> DeleteTask(int Id)
        {

            return true;
        }

    }

}


 