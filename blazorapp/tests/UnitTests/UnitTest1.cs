namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public void ShouldFail()
    {
        Assert.True(false);
    }
    
    [Fact]
    public void ShouldPass()
    {
        Assert.True(true);
    }
}