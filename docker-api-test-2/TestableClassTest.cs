using Xunit;

namespace docker_api_test_2;

public class TestableClassTest
{
    [Fact]
    public void TestSumSuccess()
    {
        var sut = new TestableClass();

        var sum = sut.Sum(1, 2);

        Assert.Equal(3,sum);
    }
 
    [Fact(Skip = "Trying skip")]
    public void TestSumWrong()
    {
        var sut = new TestableClass();

        var sum = sut.Sum(1, 2);

        Assert.Equal(99, sum);
    }
}