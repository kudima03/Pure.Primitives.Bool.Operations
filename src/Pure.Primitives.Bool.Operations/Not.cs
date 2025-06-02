using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record Not : IBool
{
    private readonly IBool _value;

    public Not(IBool value)
    {
        _value = value;
    }

    bool IBool.BoolValue => !_value.BoolValue;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}