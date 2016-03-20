using System;
using System.Configuration;
using System.Diagnostics;

namespace ClassMarkerTesting.SeleniumUtilities
{
    public static class Wait
    {
        public static bool Until(Func<bool> action, int timeInSeconds = 1)
        {
            var watch = new Stopwatch();
            watch.Start();
            Core.Browser.BrowserDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeInSeconds));

            var actionSucceded = false;
            try
            {
                while (watch.Elapsed.Seconds < timeInSeconds && !actionSucceded)
                {
                    actionSucceded = action();
                }
            }
            catch
            {
            }
            finally
            {
                watch.Stop();
                Core.Browser.BrowserDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["Timeout"])));
            }

            return actionSucceded;
        }
    }
}
