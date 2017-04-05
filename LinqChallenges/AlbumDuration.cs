using System;
using System.Linq;

namespace LinqChallenges
{
    public class AlbumDuration
    {
        public string CalculateDuration(string tracks)
        {
            return tracks
                .Split(',')
                .Select(t => TimeSpan.Parse("0:" + t))
                .Aggregate((t1, t2) => t1 + t2)
                .ToString();
        }
    }
}
