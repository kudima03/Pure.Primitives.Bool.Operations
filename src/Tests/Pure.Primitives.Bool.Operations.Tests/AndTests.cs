using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record AndTests
{
    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool and = new And(new True(), new True(), new True(), new True());
        Assert.True(and.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool and = new And(new False(), new False(), new False(), new False());
        Assert.False(and.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool and = new And(new True(), new True(), new True(), new False());
        Assert.False(and.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool and = new And(new True(), new False(), new False(), new False());
        Assert.False(and.Value);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool and = new And();
        Assert.Throws<ArgumentException>(() => and.Value);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new And().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new And().ToString());
    }
}