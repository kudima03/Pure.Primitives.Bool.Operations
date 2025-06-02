using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record NotTests
{
    [Fact]
    public void ProduceCorrectValueOnTrue()
    {
        IBool value = new Not(new True());
        Assert.False(value.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnFalse()
    {
        IBool value = new Not(new False());
        Assert.True(value.BoolValue);
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