using Xunit.Abstractions;

namespace FamilyEfc;

public class UnitTest1(ITestOutputHelper printer)
{
    [Fact]
    public void ExamplePrint()
    {
        printer.WriteLine("");
    }
}