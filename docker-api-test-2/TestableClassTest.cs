using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace docker_api_test_2;

public class TestableClassTest
{
    [Fact]
    public void TestSumSuccess()
    {
        var sut = new TestableClass();

        var sum = sut.Sum(1, 2);

        Assert.Equals(sum, 3);
    }
 
    [Fact]
    public void TestSumWrong()
    {
        var sut = new TestableClass();

        var sum = sut.Sum(1, 2);

        Assert.Equals(sum, 99);
    }
}