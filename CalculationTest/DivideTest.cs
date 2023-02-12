using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationTest 
{   
    public class DivideTest 
    {
        
        int actualResult;
        int expectedResult;
        
        
       [Test]
        public void Divide()
        {
            expectedResult = 5;
            actualResult = UnitTest1.DivideIntegers(120 ,0);
            Assert.True(actualResult==, $"Expected result is {expectedResult}");
            }

        [Test]
        public void ValueOutOfRange()
        {
            actualResult = UnitTest1.DivideIntegers(1200, 2000);
            
        }

        [Test]
        public void CorrectCalculation()
        {
            expectedResult = 20;
            actualResult = UnitTest1.DivideIntegers(100, 5);
            Assert.True(actualResult == expectedResult, $"Expected result is {expectedResult}");
        }
    }
}
