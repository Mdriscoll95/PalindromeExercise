using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("tattarrattat", true)]
        [InlineData("hey", false)]
        public void PalindromTest(string word, bool expected)
        {
            //arrange
            var wordsmith = new WordSmith();

            //act
            var actual = wordsmith.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
