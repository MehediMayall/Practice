using BenchmarkDotNet.Attributes;

namespace BenchmarkDemo;


[MemoryDiagnoser]
public class SubstringVsSpanTest
{
    public string date = "08 12 2023";

    [Benchmark]
    public (int, int, int) GetYearMonthDayUsingSubstring()
    {
        return (
            int.Parse(date.Substring(0,2)),
            int.Parse(date.Substring(3,2)),
            int.Parse(date.Substring(6))
        );
    }
    [Benchmark]
    public (int, int, int) GetYearMonthDayUsingSpan()
    {
        ReadOnlySpan<char> dateAsSpan = date;
        return (
            int.Parse(dateAsSpan.Slice(0,2)),
            int.Parse(dateAsSpan.Slice(3,2)),
            int.Parse(dateAsSpan.Slice(6))
        );
    }

}