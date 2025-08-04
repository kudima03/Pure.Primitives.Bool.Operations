using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool.Operations.Tests.Fakes;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record AndTests
{
    [Fact]
    public void NotEvaluateAfterFirstFalse()
    {
        IReadOnlyCollection<BoolWithEvaluationMarker> values =
        [
            .. Enumerable
                .Range(0, 10)
                .Select(_ => new BoolWithEvaluationMarker(true))
                .Prepend(new BoolWithEvaluationMarker(false)),
        ];
        IBool and = new And(values);
        _ = and.BoolValue;
        Assert.True(values.Skip(1).All(x => !x.Evaluated));
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool and = new And(new True(), new True(), new True(), new True());
        Assert.True(and.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool and = new And(new False(), new False(), new False(), new False());
        Assert.False(and.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool and = new And(new True(), new True(), new True(), new False());
        Assert.False(and.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool and = new And(new True(), new False(), new False(), new False());
        Assert.False(and.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool and = new And();
        _ = Assert.Throws<ArgumentException>(() => and.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new And().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new And().ToString());
    }
}
