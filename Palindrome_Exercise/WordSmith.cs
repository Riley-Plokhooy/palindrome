using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Exercise;

public class WordSmith
{
    public bool ISAPalindrome(string word)
    {
        if (word == null || word.Length == 0) 
        {
            return false;        
        }

        string wordLowered = word.ToLower();
        
        string backwards = "";

        for (int i = wordLowered.Length - 1; i >= 0; i--) 
        {
            backwards += wordLowered[i];
        }

        if (wordLowered == backwards)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}

