using AspNet.Algorithms;
using FluentAssertions;

namespace AspNet.Algorithms.Test;

public class HastableTests
{

    [Fact(DisplayName = "Get the exactly value passed on the key")]
    public void TestOne()
    {
        var hash = new Hastable<int, int>(1);

        hash.Add(1,1);

        var result = hash.Get(1);

        result.Should().Be(1);
    }
}
