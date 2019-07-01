using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TodoListTests.Controllers
{
    [TestClass]
    public class ToDoHelperTest
    {
        [TestMethod]
        public void ToDoHelperTest_Success()
        {
            Mock<IToDoHelper> mockTodoHelper = new Mock<IToDoHelper>();

        }
    }
}
