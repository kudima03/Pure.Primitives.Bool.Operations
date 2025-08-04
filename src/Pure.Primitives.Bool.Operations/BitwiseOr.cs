using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record BitwiseOr : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public BitwiseOr(params IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    bool IBool.BoolValue =>
        !_parameters.Any()
            ? throw new ArgumentException()
            : _parameters.Any(parameter => parameter.BoolValue);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
