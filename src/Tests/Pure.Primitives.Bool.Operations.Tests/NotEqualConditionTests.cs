using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record NotEqualConditionTests
{
    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool condition = new NotEqualCondition(
            new True(),
            new True(),
            new True(),
            new True()
        );
        Assert.False(condition.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool condition = new NotEqualCondition(
            new False(),
            new False(),
            new False(),
            new False()
        );
        Assert.False(condition.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool condition = new NotEqualCondition(
            new True(),
            new True(),
            new True(),
            new False()
        );
        Assert.True(condition.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool condition = new NotEqualCondition(
            new True(),
            new False(),
            new False(),
            new False()
        );
        Assert.True(condition.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool condition = new NotEqualCondition();
        _ = Assert.Throws<ArgumentException>(() => condition.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new NotEqualCondition().GetHashCode()
        );
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() =>
            new NotEqualCondition().ToString()
        );
    }
}
