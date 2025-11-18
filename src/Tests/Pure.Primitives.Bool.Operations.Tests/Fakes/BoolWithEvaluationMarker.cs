using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations.Tests.Fakes;

public sealed record BoolWithEvaluationMarker : IBool
{
    public BoolWithEvaluationMarker(bool boolValue)
    {
        BoolValue = boolValue;
    }

    public bool BoolValue
    {
        get
        {
            Evaluated = true;
            return field;
        }
    }

    public bool Evaluated { get; private set; }
}
