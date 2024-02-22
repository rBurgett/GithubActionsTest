using GithubActionsUtil;

namespace GithubActionsTestTests;

public class UtilTests
{
    [Fact]
    public void TestGetSome()
    {
        var some = Util.GetSome();
        some.Should().Be("thing");
    }
}
