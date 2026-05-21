using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetApp.Interfaces;

namespace TimesheetApp.Util
{
    public class ErrorLogger : IErrorLogger
    {
        public void LogError(Exception error)
        {
            string message = error.Message;
            //Cuva poruku greske u bazi podataka
            throw new NotImplementedException();
        }
    }
}
