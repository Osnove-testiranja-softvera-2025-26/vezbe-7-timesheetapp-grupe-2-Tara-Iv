using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(string to, string title, string body);
    }
}
