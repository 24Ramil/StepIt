using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.Class;
using ToDoList.Model.Interfaces;

namespace ToDoList.TaskManager
{
    public class TaskManagerFactory : ITaskManagerFactory
    {
        public ITaskButton CreateTaskButton()
        {
            return new TaskButton();
        }
        public ITaskTextBox CreateTaskTextBox()
        {
            return new TaskTextBox();
        }
        public ITaskListBox CreateTaskListBox()
        {
            return new TaskListBox();
        }

    }
}
