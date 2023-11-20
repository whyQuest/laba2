using labka5;
using Xunit;
using System;

namespace testLABA5
{
    public class UnitTest1
    {
        [Fact]
        public void CalcCycle()
        {
            Class1 sinDivX = new Class1();
            double expected = -0.80000000000000004;
            double result = sinDivX.CalcCycle(1, 1);

            Assert.Equal(expected, Math.Round(result, 1));
        }

        [Fact]
        public void CalcWithRec()
        {
            Class1 sinDivX = new Class1();
            double expected = -0.80000000000000004;
            double result = sinDivX.CalcWithRec(1, 1);
            Assert.Equal(expected, Math.Round(result, 1));
        }
    }
}