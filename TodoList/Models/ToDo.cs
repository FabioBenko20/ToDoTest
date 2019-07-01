using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public interface IToDo
    {

    }
    public class ToDo: IToDo
    {
        public int IdToDo { get; set; }

        public int UserId { get; set; }

        public DateTime CreationDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Complete { get; set; }
    }
}
