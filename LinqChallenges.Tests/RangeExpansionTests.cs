using System;
using System.Collections.Generic;
using Xunit;

namespace LinqChallenges.Tests
{
    public class RangeExpansionTests
    {
        [Fact]
        public void Throws_ArgumentNullException_when_input_is_null()
        {
            RangeExpansion rangeExpansion = new RangeExpansion();

            Assert.Throws<ArgumentNullException>(() => rangeExpansion.Start(null));
        }

        [Fact]
        public void Returns_correct_sequence()
        {
            RangeExpansion rangeExpansion = new RangeExpansion();

            var input = "1,2,3,7-12,20,23-25";
            var expectedResult = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12, 20, 23, 24, 25 };

            Assert.Equal(expectedResult, rangeExpansion.Start(input));
        }
    }
}
