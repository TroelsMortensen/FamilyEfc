using Xunit.Abstractions;

namespace FamilyEfc;

public class Queries(ITestOutputHelper printer)
{
    [Fact]
    public void ExamplePrint()
    {
        printer.WriteLine("");
    }
}