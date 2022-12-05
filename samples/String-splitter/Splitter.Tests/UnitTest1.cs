namespace Splitter.Tests;

public class UnitTest1
{
    [Fact]
    public void Splitting_one_string_int_to_two_separated()
    {
        Splitter splitter= new Splitter();
        string result = splitter.CheckItOut("camelCasing");

        Assert.Equal("camel Casing", result);
    }

}
//  yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
    