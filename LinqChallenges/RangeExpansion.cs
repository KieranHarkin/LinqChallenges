using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqChallenges
{
    public class RangeExpansion
    {
        // Given the following input "2,5,7-10,11,17-18" 
        // Transform to "2,5,7,8,9,10,11,17,18"
        public IEnumerable<int> Start(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(input);
            }

            var result = input.Split(',')
                .Select(x => x.Split('-'))
                .Select(p => new { First = int.Parse(p[0]), Last = int.Parse(p.Last()) })
                .SelectMany(r => Enumerable.Range(r.First, r.Last - r.First + 1));

            return result;
        }
    }
}
