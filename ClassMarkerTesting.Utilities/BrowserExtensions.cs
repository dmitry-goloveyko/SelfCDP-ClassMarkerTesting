using System;
using System.Diagnostics;
using OpenQA.Selenium;

namespace ClassMarkerTesting.Utilities
{
    public static class BrowserExtensions
    {
        public static void WaitReadyState(this IWebDriver Browser)
        {
            const int timeout = 30;

            var watch = new Stopwatch();
            watch.Start();

            try
            {
                while (watch.Elapsed.Seconds < timeout)
                {
                    if ((string) ((IJavaScriptExecutor)Browser).ExecuteScript("return document.readyState;") == "complete")
                    {
                        return;
                    }
                }

                throw new Exception(string.Format("Page did not load for {0} seconds", timeout));
            }
            finally
            {
                watch.Stop();
            }
        }
    }
}
