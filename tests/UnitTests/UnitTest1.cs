namespace UnitTests;

public class UnitTest1
{
    private readonly string[] summaries = 
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly int summaryLength = 10;
    
    [Fact]
    public void Test1()
    {
        var length = summaries.Length;
        Assert.Equal(summaryLength, length);
    }
}