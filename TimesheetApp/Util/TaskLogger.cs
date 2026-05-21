using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetApp.Interfaces;

namespace TimesheetApp.DBAccess
{
    public class TaskLogger : ITask
    {
        public int TaskId { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Description { get; set; }

        public bool SaveToDB()
        {
            //Cuva podatke o zadatku na osnovu postavljenih vrednosti za TaskId, Hours, Minutes i Description
            throw new NotImplementedException();
        }
    }
}
