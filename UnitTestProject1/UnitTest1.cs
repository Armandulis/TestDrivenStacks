using Stack;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {

        ICalculator calc = new Calculator();
        int result;
        int current;

        [Fact]

        public void TestSubstract()
        {
            int current = calc.Add(4, 2);
            result = calc.Substract(current, 5);
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void TestAdd()
        {
            result = calc.Add(5, 0);
            Assert.Equal(5, result );
        }

        [Fact]
        public void TestMultiply()
        {
            current = calc.Add(0, 2);
           result =  calc.Multiply(3, current);
            Assert.Equal(6, result);
        }

        [Fact]

        public void TestDivide()
        {
            current =calc.Add(8, 0);
            result = calc.Divide(4, current);
            Assert.Equal(2, result);
        }


        [Fact]
        public void TestDivideException()
        {
            current = calc.Add(4, 0);
            Assert.Throws<ArgumentException>(() => calc.Divide(current, 0));
        }

        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(7, 1, 8)]
        [InlineData(5, -11, -6)]
        [InlineData(7, -13, -6)]
        public void AddTest3(int x, int y, int res)
        {
            result = calc.Add(x, y);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(8, 4, 2)]
        [InlineData(10, 5, 2)]
        public void DivideTest3(int x, int y, int res)
        {
            
            result = calc.Divide(x, y);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(7, 3, 21)]
        [InlineData(3, 2, 7)]
        [InlineData(10, 5, 50)]
        public void MultiplyTest3(int x, int y, int res)
        {
            result =calc.Multiply(x,y);
            Assert.Equal(result, res);
        }

        [Theory]
        [InlineData(5, 1, 4)]
        [InlineData(42, 3, 38)]
        [InlineData(10, 5, 5)]
        public void SubstractTest3(int x, int y, int res)
        {
            result = calc.Substract(x,y);
            Assert.Equal(result, res);
        }

        [Fact]
        public void TestStackAddAndMultiply()
        {
            Stack<int> bigStack = new Stack<int>();
            bigStack.Push(2);
            bigStack.Push(2);
            bigStack.Push(5);
            int x = bigStack.Pop();
            int y = bigStack.Pop();
            current  = calc.Add(x, y);
            result = calc.Multiply(current, bigStack.Pop());
            Assert.Equal(14, result);

        }


    }
}
