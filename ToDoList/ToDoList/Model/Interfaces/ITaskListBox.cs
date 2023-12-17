using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model.Interfaces
{
    public interface ITaskListBox
    {
        void Render(List<string> tasks);
    }
}
