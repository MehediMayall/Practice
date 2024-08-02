namespace BenchmarkDemo;


[MemoryDiagnoser]
public class ArraySumVsSpanSum
{
    [Params(100, 1000, 10000)]
    public int SIZE = 1000;
    public int[] numbers;

    [GlobalSetup]
    public void Setup()
    {
        numbers = Enumerable.Range(1, SIZE).ToArray();        
    }

    [Benchmark(Baseline = true)]
    public int SumUsingArray()
    {
        int sum = 0;
        for(int x =0 ; x< numbers.Length; x++)
            sum += numbers[x];

        return sum;
    }

    [Benchmark]
    public int SumUsingSpan()
    {
        ReadOnlySpan<int> nums =numbers.AsSpan();
        int sum = 0;
        for(int x =0 ; x< nums.Length; x++)
            sum += nums[x];

        return sum;
    }


    [Benchmark]
    public int SumUsingLinq()
    {         
        return numbers.Sum();
    }

}