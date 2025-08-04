using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record BitwiseAnd : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public BitwiseAnd(params IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    bool IBool.BoolValue =>
        !_parameters.Any()
            ? throw new ArgumentException()
            : _parameters.All(x => x.BoolValue);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
