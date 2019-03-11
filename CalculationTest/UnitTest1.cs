using NUnit.Framework;
using System;


namespace CalculationTest
{
  
    public  class UnitTest1
    {
      
    



         public static void isNumberValid(int firstValue, int secondValue)
        {

            if (firstValue <-1000 || firstValue >1000)
            {
                throw new Exception("Entered first value should be in a range <1000 or > -1000 " +"Actual entered Value is "+ firstValue );
            }
            if (secondValue <-1000 || secondValue >1000)
            {
                throw new Exception("Entered second value should be in a range <1000 or > -1000 "+ "Actual entered Value is " + secondValue);
            }
        }
            
           public static int DivideIntegers (int firstValue , int secondValue)
            {
            if (secondValue == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");

            }
                isNumberValid(firstValue,secondValue);
                return firstValue / secondValue;
        }

    }
}
