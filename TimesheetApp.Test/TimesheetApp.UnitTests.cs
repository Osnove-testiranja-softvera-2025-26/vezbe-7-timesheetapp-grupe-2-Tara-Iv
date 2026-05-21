using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TimesheetApp;
using TimesheetApp.Fakes;

namespace TimesheetApp.Test
{
    [TestFixture]
    public class TimeLoggerTests
    {
        [Test]
        public void TimeLogger_LogTime_Success()
        {
            var fakeTask = new FakeTaskLogger();
            var fakeEmail = new FakeEmailSender();
            var fakeError = new FakeErrorLogger();
            var fakeUser = new FakeUserLogger();
            var fakeTaskManager = new FakeTaskManager();

            var logger = new TimeLogger(fakeTask, fakeEmail, fakeError, fakeUser, fakeTaskManager);

            // Act
            logger.LogTime(2, 30, "Worked on feature");

            // Assert that task was populated and saved
            Assert.AreEqual(42, fakeTask.TaskId);
            Assert.AreEqual(2, fakeTask.Hours);
            Assert.AreEqual(30, fakeTask.Minutes);
            Assert.AreEqual("Worked on feature", fakeTask.Description);

            // Assert that email was sent to the user's email
            Assert.IsTrue(fakeEmail.SendCalled);
            Assert.AreEqual("test@example.com", fakeEmail.LastTo);
            Assert.IsNotNull(fakeEmail.LastTitle);
            Assert.IsTrue(fakeEmail.LastTitle.Contains("Time logged successfully"));
        }

        
    }
}
