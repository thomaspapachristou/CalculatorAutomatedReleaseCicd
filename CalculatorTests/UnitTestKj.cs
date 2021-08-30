using System;
using Xunit;
using ClassLibrary;

namespace CalculatorTests
{
    public class UnitTestKj
    {
        int intTarget = 5;
        int n = 5;

        [Fact]
        public void AdditionIsOk()
        {
            int result = ClassLib.Addition(intTarget, n);
            Assert.True(result == 10, "le résultat donne 10");
        }

        [Fact]
        public void SquareIsOk()
        {
            int result = ClassLib.Square(intTarget, n);
            Assert.True(result == 0, "Le résultat should be 0");
        }

        [Fact]
        public void MultiplicationIsOk()
        {
            int result = ClassLib.Multiplication(intTarget, n);
            Assert.True(result == 25, "Le résultat should be 25");
        }

        [Fact]
        public void DivisionISOk()
        {
            int result = ClassLib.Division(intTarget, n);
            Assert.True(result == 1, "Le résultat should be 1");
        }

        [Fact]
        public void DivisionZero()
        {
            intTarget = 0;

            Assert.Throws<DivideByZeroException>(() =>
            {
                int result = ClassLib.Division(intTarget, n);
            }
            );

        }
    }
}
