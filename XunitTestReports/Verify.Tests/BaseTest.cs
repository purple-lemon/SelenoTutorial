using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Verify.Tests
{
    public class BaseTest
    {
        private readonly ITestOutputHelper output;
        public BaseTest(ITestOutputHelper testOutputHelper)
        {
            output = testOutputHelper;
        }
        protected void UITest(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                //var screenshot = Driver.TakeScreenshot();

                var filePath = @"D:\Screenshots\test.txt";

                File.WriteAllText(filePath, "Here is my screenshot");
                output.WriteLine("Screenshot stored: " + filePath);
                // This would be a good place to log the exception message and
                // save together with the screenshot

                throw;
            }
        }
    }
}
