using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace docker_api_test_2;

public class TestableClass
{
    public int Sum(int v1, int v2)
    {
        return v1 + v2;
    }

    public int Subtract(int v1, int v2)
    {
        return v1 - v2;
    }
}