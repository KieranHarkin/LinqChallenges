using System;
using System.Collections.Generic;
using Xunit;

namespace LinqChallenges.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void Returns_True_With_Valid_Palindromes()
        {
            var palindrome = new Palindrome();

            var palindromeTests = GetPalindromes();

            foreach (var item in palindromeTests)
            {
                Assert.True(palindrome.IsPalindrome(item));
            }
        }

        [Fact]
        public void Returns_False_With_Non_Palindrome()
        {
            var palidrome = new Palindrome();

            Assert.False(palidrome.IsPalindrome("I'm not a palidrome"));
        }

        [Fact]
        public void Throws_NullReferenceException()
        {
            var palindrome = new Palindrome();

            Assert.Throws<NullReferenceException>(() => palindrome.IsPalindrome(null));
        }

        private IEnumerable<string> GetPalindromes()
        {
            // Test Palidrome list taken from http://www.palindromelist.net/ 
            var palidromeList = new List<string>()
            {
                "A but tuba",
                "A car, a man, a maraca.",
                "A dog, a plan, a canal: pagoda.",
                "A dog!A panic in a pagoda!",
                "A lad named E.Mandala",
                "A man, a plan, a canal: Panama.",
                "A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal - Panama!",
                " A new order began, a more Roman age bred Rowena.",
                "A nut for a jar of tuna.",
                "A Santa at Nasa.",
                "A Santa dog lived as a devil God at NASA.",
                "A slut nixes sex in Tulsa.",
                "A tin mug for a jar of gum, Nita.",
                "A Toyota!Race fast, safe car!A Toyota!",
                "A Toyota’s a Toyota.",
                "Able was I ere I saw Elba.",
                "Acrobats stab orca.",
                "Aerate pet area.",
                "Ah, Satan sees Natasha!",
                "Aibohphobia",
                "Air an aria.",
                "Al lets Della call Ed Stella.",
                "alula",
                "Amen icy cinema.",
                "Amore, Roma.",
                "Amy, must I jujitsu my ma ?",
                "Ana",
                "Animal loots foliated detail of stool lamina.",
                "Anna",
                "Anne, I vote more cars race Rome to Vienna.",
                "Are Mac ‘n’ Oliver ever evil on camera ?",
                "Are we not drawn onward to new era?",
                "Are we not drawn onward, we few, drawn onward to new era?",
                "Are we not pure ? “No sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man; a prisoner up to new era.",
                " Art, name no tub time. Emit but one mantra.",
                "As I pee, sir, I see Pisa!",
                "Avid diva."
            };
            return palidromeList;
        }
    }
}
