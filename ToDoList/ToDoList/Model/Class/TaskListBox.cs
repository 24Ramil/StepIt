using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.Interfaces;

namespace ToDoList.Model.Class;

public class TaskListBox : ITaskListBox
{
    public void Render(List<string> tasks)
    {
        Console.WriteLine("Task List:");
        int i = 1;
        foreach (var task in tasks)
        {
            Console.WriteLine($"{i}) {task}");
            i++;
        }
    }

}
