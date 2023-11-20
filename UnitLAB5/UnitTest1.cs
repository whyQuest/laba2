using laboratorka5;
using Xunit;
using System;

namespace UnitLAB5
{
    public class UnitTest1
    {
        [Fact]
        public void CalcCycle_ValidInput_ReturnsCorrectResult()
        {
            sinx sin = new sinx();
            double x = Math.PI / 4;
            int N = 5;
            double y = -0.23003799999999999; 
            double rez = sin.CalcCycle(x, N);

            Assert.Equal(y, Math.Round(rez, 6));
        }

        [Fact]
        public void CalcWithRec_ValidInput_ReturnsCorrectResult()
        {
            
            sinx sin = new sinx();
            double x = Math.PI / 4;
            int N = 5; 
            double y = -0.23003799999999999; 
            double rez = sin.CalcWithRec(x, N);

 
            Assert.Equal(y, Math.Round(rez, 6));
        }
    }
}