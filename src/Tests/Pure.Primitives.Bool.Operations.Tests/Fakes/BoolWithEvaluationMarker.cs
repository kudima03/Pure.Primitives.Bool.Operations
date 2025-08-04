using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests.Fakes;

public sealed record BoolWithEvaluationMarker : IBool
{
    private readonly bool _value;

    public BoolWithEvaluationMarker(bool boolValue)
    {
        _value = boolValue;
    }

    public bool BoolValue
    {
        get
        {
            Evaluated = true;
            return _value;
        }
    }

    public bool Evaluated { get; private set; }
}
