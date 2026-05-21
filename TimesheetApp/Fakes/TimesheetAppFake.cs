using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetApp.Interfaces;

namespace TimesheetApp.Fakes
{
    public class FakeTaskLogger : ITask
    {
        public int TaskId { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Description { get; set; }
        public bool SaveToDB()
        {
            return true;
        }
        public bool AlwaysSaveToDB() 
        { 
            return true; 
        }
    
    }

    public class FakeUserLogger : IUserLogger
    {
        public string GetLoggedUserName()
        {
            return "testuser";
        }

        public string GetLoggedUserEmail(string userName)
        {
            return "test@example.com";
        }
    }

    public class FakeTaskManager : ITaskManager
    {
        public int GetTaskId(string loggedUserName, string loggedUserEmail)
        {
            return 42;
        }
    }

    public class FakeEmailSender : IEmailSender
    {
        public bool SendCalled { get; private set; }
        public string LastTo { get; private set; }
        public string LastTitle { get; private set; }
        public string LastBody { get; private set; }

        public void SendEmail(string to, string title, string body)
        {
            SendCalled = true;
            LastTo = to;
            LastTitle = title;
            LastBody = body;
        }
    }

    public class FakeErrorLogger : IErrorLogger
    {
        public Exception LastError { get; private set; }
        public void LogError(Exception error)
        {
            LastError = error;
        }
    }

    // Fake that simulates failure when saving to database
    public class FakeTaskLoggerFail : ITask
    {
        public int TaskId { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public string Description { get; set; }
        public bool SaveToDB()
        {
            return false;
        }
    }
}
