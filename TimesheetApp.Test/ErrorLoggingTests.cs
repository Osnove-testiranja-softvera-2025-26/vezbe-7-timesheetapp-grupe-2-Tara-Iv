using System;
using NUnit.Framework;
using TimesheetApp;
using TimesheetApp.Fakes;

namespace TimesheetApp.Test
{
    [TestFixture]
    public class ErrorLoggingTests
    {
        [Test]
        public void TimeLogger_LogTime_WhenSaveFails_LogsError()
        {
            var fakeTask = new FakeTaskLoggerFail();
            var fakeEmail = new FakeEmailSender();
            var fakeError = new FakeErrorLogger();
            var fakeUser = new FakeUserLogger();
            var fakeTaskManager = new FakeTaskManager();

            var logger = new TimeLogger(fakeTask, fakeEmail, fakeError, fakeUser, fakeTaskManager);

            try
            {
                logger.LogTime(1, 15, "Some work");
                Assert.Fail("Expected exception when SaveToDB fails");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Failed to save data to database", ex.Message);
                Assert.IsNotNull(fakeError.LastError);
                Assert.AreEqual("Failed to save data to database", fakeError.LastError.Message);
                Assert.IsFalse(fakeEmail.SendCalled);
            }
        }
    }
}
