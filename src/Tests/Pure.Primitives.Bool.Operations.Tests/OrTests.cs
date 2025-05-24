using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record OrTests
{
    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool or = new Or(new True(), new True(), new True(), new True());
        Assert.True(or.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool or = new Or(new False(), new False(), new False(), new False());
        Assert.False(or.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool or = new Or(new True(), new True(), new True(), new False());
        Assert.True(or.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool or = new Or(new True(), new False(), new False(), new False());
        Assert.True(or.Value);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool or = new Or();
        Assert.Throws<ArgumentException>(() => or.Value);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Or().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Or().ToString());
    }
}