using BenchmarkDotNet.Attributes;

namespace EsmondBenchmark.Console;

public class FirstTest
{
    [Benchmark]
    public int ReturnConstant () 
    {
        return 1;
    }

    [Benchmark]
    public int ReturnMax () 
    {
        return int.MaxValue;
    }
}
