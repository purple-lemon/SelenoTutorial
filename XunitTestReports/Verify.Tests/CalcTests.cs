using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verify.Code;
using Xunit;
using Xunit.Abstractions;

namespace Verify.Tests
{
    [Collection("Calculator tests")]
    public class CalcTests : BaseTest
    {

        public CalcTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
        [Fact(DisplayName = "Test sum")]
        public void SumTest()
        {
            UITest(() =>
            {
                var ticks = DateTime.Now.Ticks;
                var date = DateTime.Now;
                var secs = date.Second + 60 * date.Minute + 3600 * date.Hour;
                var calc = new Calculator();
                
                Assert.Equal(5, calc.Sum(2, 4));
            });
        }

        [Fact(DisplayName = "Test substraction")]
        public void SubTest()
        {
            var calc = new Calculator();

            Assert.Equal(5, calc.Substract(8, 3));
        }

        [Fact(DisplayName = "Test multiplication")]
        public void MultTest()
        {
            var calc = new Calculator();
            Assert.Equal(6, 2*3);
        }
    }
}
