using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Interfaces
{
    public interface ITaskManager
    {
        int GetTaskId(string loggedUserName, string loggedUserEmail);
    }
}
