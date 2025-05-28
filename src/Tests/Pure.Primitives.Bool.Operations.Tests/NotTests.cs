using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record NotTests
{
    [Fact]
    public void ProduceCorrectValueOnTrue()
    {
        IBool BoolValue = new Not(new True());
        Assert.False(BoolValue.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnFalse()
    {
        IBool BoolValue = new Not(new False());
        Assert.True(BoolValue.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Not(new True()).GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Not(new True()).ToString());
    }
}