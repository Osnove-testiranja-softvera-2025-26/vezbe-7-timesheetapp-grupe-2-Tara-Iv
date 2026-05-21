using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetApp.Interfaces;

namespace TimesheetApp.Util
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string to, string title, string body)
        {
            //sklapa i salje mejl na osnovu dobijenih parametara
            throw new NotImplementedException();
        }
    }
}
