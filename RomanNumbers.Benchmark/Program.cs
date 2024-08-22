using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using RomanNumbersConverter;

[RPlotExporter]
public class Converters
{
    [Benchmark]
    public int Backwords() => RomanNumberConverter.ConvertBackwords("MMXIII");
}
public class RomanNumbersBenchmark
{

    static void Main()
    {
        var summary = BenchmarkRunner.Run<Converters>();
    }

}