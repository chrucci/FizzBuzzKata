using System;
using NUnit.Framework;

namespace FizzBuzzTests
{
    public class Tests
    {
        [Test]
        public void GetValue_WhenDivisibleBy3_ReturnsFizz()
        {
            var expected = "Fizz";
            Assert.AreEqual(expected, FizzBuzz.GetValue(3));
        }
        
        [Test]
        public void GetValue_WhenDivisibleBy5_ReturnsBuzz()
        {
            var expected = "Buzz";
            Assert.AreEqual(expected, FizzBuzz.GetValue(5));
        }
        
        [Test]
        public void GetValue_WhenDivisibleByBoth3And5_ReturnsFizzBuzz()
        {
            var expected = "FizzBuzz";
            Assert.AreEqual(expected, FizzBuzz.GetValue(15));
        }
        
        [Test]
        public void GetValue_WhenDivisibleByNeither3Nor5_ReturnsTheNumber()
        {
            var expected = "2";
            Assert.AreEqual(expected, FizzBuzz.GetValue(2));
        }

        [Test]
        public void GetPrintString_WhenPassedLength_ReturnsFizzBuzzString()
        {
            var actual = FizzBuzz.GetPrintString(3);
            var nl = Environment.NewLine;
            var expected = $"1{nl}2{nl}Fizz{nl}";
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPrintString_WhenPassedLengthGreaterThan15_ReturnsFizzBuzzString()
        {
            var actual = FizzBuzz.GetPrintString(16);
            var nl = Environment.NewLine;
            var expected = $"1{nl}2{nl}Fizz{nl}4{nl}Buzz{nl}Fizz{nl}7{nl}8{nl}Fizz{nl}Buzz{nl}11{nl}Fizz{nl}13{nl}14{nl}FizzBuzz{nl}16{nl}";
            
            Assert.AreEqual(expected, actual);
        }
        
    }

    public static class FizzBuzz
    {
        public static string GetValue(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";
            return i.ToString();
        }

        public static string GetPrintString(int length)
        {
            var returnVal = "";
            for (int i = 1; i <= length; i++)
            {
                returnVal += GetValue(i) + Environment.NewLine;
            }
            return returnVal;
        }
    }
}