using FluentAssertions;
using FluentAssertions.Extensions;

namespace FunctionalTasks.Tests;

public class Test
{
    [Fact]
    public async Task Or()
    {
        var t1 = Task.Delay(2.Seconds());
        var t2 = Task.Delay(2.Seconds());

        await t1.Or(t2);
    }
    
    [Fact]
    public async Task OrResult()
    {
        var t1 = Task.Run(() => 1);
        var t2 = Task.Run(() => 2);

        var result = await await t1.Or(t2);
        result.Should().Be(1);
    }
    
    [Fact]
    public async Task And()
    {
        var t1 = Task.Delay(2.Seconds());
        var t2 = Task.Delay(2.Seconds());

        await t1.And(t2);
    }
}