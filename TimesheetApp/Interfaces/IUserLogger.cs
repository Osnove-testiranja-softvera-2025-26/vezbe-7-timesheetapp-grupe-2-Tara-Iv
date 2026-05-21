using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesheetApp.Interfaces
{
    public interface IUserLogger
    {
        string GetLoggedUserName();

        string GetLoggedUserEmail(string userName);
    }
}
