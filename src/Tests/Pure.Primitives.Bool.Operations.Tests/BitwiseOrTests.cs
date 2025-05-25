using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool.Operations.Tests.Fakes;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record BitwiseOrTests
{
    [Fact]
    public void EvaluatesAll()
    {
        IReadOnlyCollection<BoolWithEvaluationMarker> values =
            Enumerable.Range(0, 10).Select(_ => new BoolWithEvaluationMarker(false))
                .Prepend(new BoolWithEvaluationMarker(true))
                .ToArray();
        IBool bitwiseOr = new BitwiseOr(values);
        _ = bitwiseOr.Value;
        Assert.True(values.All(x => x.Evaluated));
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool bitwiseOr = new BitwiseOr(new True(), new True(), new True(), new True());
        Assert.True(bitwiseOr.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool bitwiseOr = new BitwiseOr(new False(), new False(), new False(), new False());
        Assert.False(bitwiseOr.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool bitwiseOr = new BitwiseOr(new True(), new True(), new True(), new False());
        Assert.True(bitwiseOr.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool bitwiseOr = new BitwiseOr(new True(), new False(), new False(), new False());
        Assert.True(bitwiseOr.Value);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool bitwiseOr = new BitwiseOr();
        Assert.Throws<ArgumentException>(() => bitwiseOr.Value);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new BitwiseOr().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new BitwiseOr().ToString());
    }
}