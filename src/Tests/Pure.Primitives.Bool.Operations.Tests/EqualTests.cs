﻿using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool.Operations.Tests.Fakes;

namespace Pure.Primitives.Bool.Operations.Tests;

public sealed record EqualTests
{
    [Fact]
    public void ProduceCorrectValueOnAllTrue()
    {
        IBool condition = new EqualCondition(new True(), new True(), new True(), new True());
        Assert.True(condition.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalse()
    {
        IBool condition = new EqualCondition(new False(), new False(), new False(), new False());
        Assert.True(condition.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllTrueOneFalse()
    {
        IBool condition = new EqualCondition(new True(), new True(), new True(), new False());
        Assert.False(condition.BoolValue);
    }

    [Fact]
    public void ProduceCorrectValueOnAllFalseOneTrue()
    {
        IBool condition = new EqualCondition(new True(), new False(), new False(), new False());
        Assert.False(condition.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnEmptyArguments()
    {
        IBool condition = new EqualCondition();
        Assert.Throws<ArgumentException>(() => condition.BoolValue);
    }

    [Fact]
    public void ThrowsExceptionOnGetHashCode()
    {
        Assert.Throws<NotSupportedException>(() => new EqualCondition().GetHashCode());
    }

    [Fact]
    public void ThrowsExceptionOnToString()
    {
        Assert.Throws<NotSupportedException>(() => new EqualCondition().ToString());
    }
}