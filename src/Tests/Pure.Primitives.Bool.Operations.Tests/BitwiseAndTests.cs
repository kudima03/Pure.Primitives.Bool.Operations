using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool.Operations.Tests.Fakes;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record BitwiseAndTests
{
    [Fact]
    public void EvaluatesAll()
    {
        IReadOnlyCollection<BoolWithEvaluationMarker> values =
        [
            .. Enumerable
                .Range(0, 10)
                .Select(_ => new BoolWithEvaluationMarker(true))
                .Prepend(new BoolWithEvaluationMarker(false)),
        ];
        IBool bitwiseAnd = new BitwiseAnd(values);
        _ = bitwiseAnd.BoolValue;
        Assert.True(values.All(x => x.Evaluated));
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool bitwiseAnd = new BitwiseAnd(new True(), new True(), new True(), new True());
        Assert.True(bitwiseAnd.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool bitwiseAnd = new BitwiseAnd(
            new False(),
            new False(),
            new False(),
            new False()
        );
        Assert.False(bitwiseAnd.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool bitwiseAnd = new BitwiseAnd(
            new True(),
            new True(),
            new True(),
            new False()
        );
        Assert.False(bitwiseAnd.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool bitwiseAnd = new BitwiseAnd(
            new True(),
            new False(),
            new False(),
            new False()
        );
        Assert.False(bitwiseAnd.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool bitwiseAnd = new BitwiseAnd();
        _ = Assert.Throws<ArgumentException>(() => bitwiseAnd.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        _ = Assert.Throws<NotSupportedException>(() => new BitwiseAnd().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        _ = Assert.Throws<NotSupportedException>(() => new BitwiseAnd().ToString());
    }
}
