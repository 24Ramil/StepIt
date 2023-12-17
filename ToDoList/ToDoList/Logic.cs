using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.Interfaces;
using ToDoList.TaskManager;

namespace ToDoList;

public class ToDoListApp(ITaskManagerFactory factory)
{
    private ITaskButton addButton = factory.CreateTaskButton();
    private ITaskTextBox textBox = factory.CreateTaskTextBox();
    private ITaskListBox listBox = factory.CreateTaskListBox();

    private List<string> tasks = [];

    public void Run()
    {
        while (true)
        {
            addButton.Render();
            Console.WriteLine("Enter task: ");
            var task = Console.ReadLine();

            if (task != null) 
            { 
                tasks.Add(task);
            }

            Console.Clear();
            listBox.Render(tasks);
        }
    }
}
