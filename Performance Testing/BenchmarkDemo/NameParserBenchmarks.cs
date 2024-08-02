using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo;

[MemoryDiagnoser]
public class NameParserBenchmarks
{
    private const string FullName = "Mehedi Hasan";
    
    
    [Benchmark]
    public void GetLastName() =>
        FullName.Split(' ').Last();
}