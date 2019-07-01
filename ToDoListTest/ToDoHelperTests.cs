using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoList.Controllers;
using TodoList.Helpers.Interfaces;
using TodoList.Models;

namespace ToDoListTest
{
    [TestClass]
    public class ToDoHelperTests
    {
        [TestMethod]
        public async Task ToDoHelperTest_GetAll_Success()
        {
            List<ToDo> to = new List<ToDo>();
            Mock<IToDoService> mockTodoService = new Mock<IToDoService>();

            mockTodoService.Setup(t => t.GetAll()).ReturnsAsync(to).Verifiable();


            ToDoHelper todo = new ToDoHelper(mockTodoService.Object);

            var result = await todo.GetAll();

            Assert.IsInstanceOfType(result, typeof(List<ToDo>));

        }
    }
}
