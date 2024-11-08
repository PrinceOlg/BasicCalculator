using System;

namespace BasicPrivateAssembly
{
    public class BasicComputation
    {
        public static float Add(float txtnum1, float txtnum2)
        {
            return txtnum1 + txtnum2;
        }
        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }

    }
}
