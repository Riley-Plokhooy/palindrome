using Palindrome_Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Excercise_Test;

public class WordSmithTests
{
    [Theory]
    [InlineData("racecar", true)]
    [InlineData("Racecar", true)]
    [InlineData("hannah", true)]
    [InlineData("kayak", true)]
    [InlineData("potassium", true)]
    [InlineData("palindrome", true)]
    [InlineData("ginger", true)]
    [InlineData("null", false)]
    [InlineData("", false)]
    public void IsAPalindrome_Test(string word, bool expected) 
    {
        var ws = new WordSmith();

        var actual = ws.ISAPalindrome(word);

        Assert.Equal(expected, actual);
    }
}
