using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verify.Code;
using Xunit;

namespace Verify.Tests
{
    [Collection("Calculator tests")]
    public class CalcTests
    {
        [Fact(DisplayName = "Test sum")]
        public void SumTest()
        {
            var ticks = DateTime.Now.Ticks;
            var date = DateTime.Now;
            var secs = date.Second + 60 * date.Minute + 3600 * date.Hour;
            var calc = new Calculator();
            Assert.Equal(5, calc.Sum(2, 3));
        }

        [Fact(DisplayName = "Test substraction")]
        public void SubTest()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Substract(8, 4));
        }
    }
}
