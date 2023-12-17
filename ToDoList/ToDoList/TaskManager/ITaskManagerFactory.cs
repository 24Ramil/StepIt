using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.Interfaces;

namespace ToDoList.TaskManager
{
    public interface ITaskManagerFactory
    {
        ITaskButton CreateTaskButton();
        ITaskTextBox CreateTaskTextBox();
        ITaskListBox CreateTaskListBox();
    }
}
