using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool.Operations.Tests.Fakes;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record OrTests
{
    [Fact]
    public void NotEvaluateAfterFirstTrue()
    {
        IReadOnlyCollection<BoolWithEvaluationMarker> values =
            Enumerable.Range(0, 10).Select(_ => new BoolWithEvaluationMarker(false))
                .Prepend(new BoolWithEvaluationMarker(true))
                .ToArray();
        IBool or = new Or(values);
        _ = or.Value;
        Assert.True(values.Skip(1).All(x => x.Evaluated is false));
    }

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