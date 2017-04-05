using Xunit;
using FluentAssertions;

namespace LinqChallenges.Tests
{
    public class AlbumDurationTests
    {
        [Theory]
        [InlineData("2:15,3:50,4:21,3:42,6:08", "00:20:16")]
        [InlineData("3:26,4:03,5:32,2:33,3:03", "00:18:37")]
        [InlineData("4:37,5:10,6:43,5:34,4:01", "00:26:05")]
        [InlineData("5:48,6:20,7:54,6:55,3:17", "00:30:14")]
        [InlineData("6:59,7:30,8:15,8:26,4:09", "00:35:19")]
        [InlineData("7:00,8:40,9:26,1:27,2:22", "00:28:55")]
        [InlineData("8:11,9:50,10:37,3:18,2:37", "00:34:33")]
        [InlineData("9:22,10:10,11:48,7:39,1:18", "00:40:17")]
        public void Returns_the_correct_album_length(string tracks, string expectedDuration)
        {
            var albumDuration = new AlbumDuration();

            var result = albumDuration.CalculateDuration(tracks);

            result.Should().BeEquivalentTo(expectedDuration);
        }

        [Fact]
        public void Should_Fail_Passes_In_Incorrect_Album_Length()
        {
            var albumnDuration = new AlbumDuration();

            var tracks = "2:15,3:50,4:21,3:42,6:08";
            var duration = "00:20:01";

            var result = albumnDuration.CalculateDuration(tracks);

            result.Should().NotBe(duration);
        }
    }
}
