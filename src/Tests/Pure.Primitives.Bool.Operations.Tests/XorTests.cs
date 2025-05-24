using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record XorTests
{
    [Fact]
    public void ProduceCorrectValueOnTrueTrue()
    {
        IBool xor = new Xor(new True(), new True());
        Assert.Equal(true ^ true, xor.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnFalseFalse()
    {
        IBool xor = new Xor(new False(), new False());
        Assert.Equal(false ^ false, xor.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnFalseTrue()
    {
        IBool xor = new Xor(new False(), new True());
        Assert.Equal(false ^ true, xor.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnTrueFalse()
    {
        IBool xor = new Xor(new True(), new False());
        Assert.Equal(true ^ false, xor.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnOdd()
    {
        IBool xor = new Xor(new True(), new False(), new False(), new True(), new True(), new False());
        Assert.Equal(true ^ false ^ false ^ true ^ true ^ false, xor.Value);
    }

    [Fact]
    public void ProduceCorrectValueOnEven()
    {
        IBool xor = new Xor(new True(), new False(), new False(), new True(), new False());
        Assert.Equal(true ^ false ^ false ^ true ^ false,xor.Value);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool xor = new Xor();
        Assert.Throws<ArgumentException>(() => xor.Value);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new Xor().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new Xor().ToString());
    }
}