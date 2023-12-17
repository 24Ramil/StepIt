using ToDoList;
using ToDoList.Model.Interfaces;
using ToDoList.TaskManager;


ITaskManagerFactory managerFactory = new TaskManagerFactory();
var ToDoList = new ToDoListApp(managerFactory);

ToDoList.Run();