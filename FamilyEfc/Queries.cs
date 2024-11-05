using FamilyEfc.Entities;
using Xunit.Abstractions;

namespace FamilyEfc;

public class Queries(ITestOutputHelper printer)
{
    private FamilyContext ctx = new();

    [Fact]
    public void ExamplePrint()
    {
        // I have some helper methods to pretty print to the unit test output console.
        // Here are some examples:
        // some tables are wide, you may have to zoom out.

        Adult first = ctx.Adults.First();
        printer.PrintJson(first);
        printer.WriteLine("\n\n");

        printer.PrintObject(first);
        printer.WriteLine("\n\n");

        List<Adult> adults = ctx.Adults.Take(10).ToList();
        printer.PrintList(adults);
    }
    
    /**
     * Below are questions to be answered.
     * Challenge: Use only the Families DbSet: ctx.Families.
     */

    // answer 151
    [Fact]
    public virtual void HowManyFamiliesHaveOneParent()
    {
        // we are looking for the number families, which have exactly one parent.
    }

    // answer: 123
    [Fact]
    public virtual void HowManyFamiliesLiveInNumberThreeOrFive()
    {
        // no matter which street, just focus on house number
    }


    // answer: 94
    [Fact]
    public virtual void HowManyFamiliesHaveADog()
    {
        // one or more dogs
    }

    // answer: 18
    [Fact]
    public virtual void HowManyFamiliesHaveCatAndDog()
    {
        // one or more of either. But at least one dog, and at least one cat
    }


    // answer 125
    [Fact]
    public virtual void HowManyFamiliesHave3Children()
    {
        // exactly 3 children
    }

    // answer: 175
    [Fact]
    public virtual void How_Many_Families_Have_Gay_Parents()
    {
        // looking for families with two parents of the same sex
        // this one is pretty tough in one query, if you don't all ToList() before the end.
    }


    // answer 21
    [Fact]
    public virtual void How_Many_Families_Have_An_Adult_With_Red_Hair()
    {
        // count the number of families with at least one adult with red hair.
    }


    // answer: 26
    [Fact]
    public virtual void How_Many_Families_Have_2_Pets()
    {
        // Exactly 2 pets. Doesn't matter what type of pet. Ignore the children's pets for this one.
    }


    // answer: 81
    [Fact]
    public virtual void How_Many_Families_Have_A_Child_Playing_Soccer()
    {
        // at least one child.
    }

    // answer: 355
    [Fact]
    public virtual void How_Many_Families_Have_Adult_And_Child_With_Black_Hair()
    {
        // count number of families where at least one adult and one child have black hair
    }


    // answer: 47
    [Fact]
    public virtual void How_Many_Families_Have_A_Child_With_Black_Hair_Playing_Ultimate()
    {
        // count number of families where at least one child has black hair and plays ultimate
    }


    // answer: 172
    [Fact]
    public virtual void HowManyFamiliesHaveTwoAdultsWithSameHairColor()
    {
    }

    // answer: 90
    [Fact]
    public virtual void HowManyFamiliesHaveAChildWithAHamster()
    {
    }


    // Answer: 5
    [Fact]
    public virtual void HowManyChildrenAreInterestedInBothSoccerAndBarbies()
    {
    }


    // answer 157
    [Fact]
    public virtual void HowManyChildrenAreOfHeightBetween95And112()
    {
    }
}