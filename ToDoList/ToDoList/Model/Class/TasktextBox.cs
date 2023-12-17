using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.Interfaces;

namespace ToDoList.Model.Class;

public class TaskTextBox : ITaskTextBox
{
    public void Render()
    {
        Console.WriteLine("Text Field");
    }
}
