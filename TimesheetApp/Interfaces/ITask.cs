using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Interfaces
{
    public interface ITask
    {
        int TaskId { get; set; }
        int Hours { get; set; }
        int Minutes { get; set; }
        string Description { get; set; }
        bool SaveToDB();
    }
}
