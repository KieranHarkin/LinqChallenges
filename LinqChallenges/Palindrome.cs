using System;
using System.Linq;

namespace LinqChallenges
{
    public class Palindrome
    {
        public bool IsPalindrome(string input)
        {
            var cleanString = new string(input.ToLower().Where(Char.IsLetter).ToArray());

            return new string(cleanString.ToCharArray().Reverse().ToArray()).CompareTo(cleanString) == 0;
        }
    }
}
