using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.Interfaces;
using TodoList.Models;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoHelper _toDoHelper;

        public ToDoController(IToDoHelper toDoHelper)
        {
            _toDoHelper = toDoHelper;
        }


        [HttpGet]
        public async Task<ActionResult<List<ToDo>>> Task()
        {

            return await _toDoHelper.GetAll();
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<ActionResult<ToDo>> Task(int id)
        {
            return await _toDoHelper.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> TaskUpload([FromBody] ToDo task)
        {
            return await _toDoHelper.Post(task);
        }

        [HttpDelete]
        [Route("{Id}")]
        public async Task<ActionResult<bool>> TaskDelete(int id)
        {
            return await _toDoHelper.Delete(id);
        }
    }
}