using System;

namespace ClassLibrary
{
    public class ClassLib
    {

        public static int Addition(int intTarget, int n)
        {
            return intTarget + n;
        }

        public static int Square(int intTarget, int n)
        {
            return intTarget - n;
        }

        public static int Multiplication(int intTarget, int n)
        {
            return intTarget * n; 
        }

        public static int Division(int intTarget, int n)
        {
            
            if (intTarget == 0 || n == 0)
            {
                throw new DivideByZeroException("You can't divide by 0");
            }

            return intTarget / n;
        }

    }
}
