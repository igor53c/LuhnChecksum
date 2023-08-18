using System;
using Xunit;
using LuhnCsharpImplementation;

namespace LuhnAlgorithmTests
{
    public class LuhnAlgorithmTest
    {
        [Fact]
        public void TestIsValidWithSingleDigit()
        {
            Assert.False(LuhnAlgorithm.IsValid("1"));
        }

        [Fact]
        public void TestIsValidWithValidThreeDigitNumber()
        {
            Assert.True(LuhnAlgorithm.IsValid("059"));
        }

        [Fact]
        public void TestIsValidWithValidNumberContainingSpaces()
        {
            Assert.True(LuhnAlgorithm.IsValid("055 444 285"));
        }

        [Fact]
        public void TestIsValidWithInvalidCharacter()
        {
            Assert.False(LuhnAlgorithm.IsValid("059a"));
        }

        [Fact]
        public void TestIsValidWithSpecialCharacters()
        {
            Assert.False(LuhnAlgorithm.IsValid("055# 444$ 285"));
        }

        [Fact]
        public void TestIsValidWithZeros()
        {
            Assert.True(LuhnAlgorithm.IsValid("0000 0"));
        }
        [Fact]
        public void TestIsValidWithHyphens()
        {
            Assert.False(LuhnAlgorithm.IsValid("055-444-285"));
        }
    }
}
