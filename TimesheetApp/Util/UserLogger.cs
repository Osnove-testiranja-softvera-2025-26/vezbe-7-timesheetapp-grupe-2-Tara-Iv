using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetApp.Interfaces;

namespace TimesheetApp.Util
{
    public class UserLogger : IUserLogger
    {
        public string GetLoggedUserEmail(string userName)
        {
            //Vraca email korisnika na osnovu njegovog username-a
            throw new NotImplementedException();
        }

        public string GetLoggedUserName()
        {
            //Vraca username trenutno logovanog korisnika
            throw new NotImplementedException();
        }
    }
}
