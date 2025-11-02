using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record BitwiseAnd : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public BitwiseAnd(params IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    public bool BoolValue =>
        !_parameters.Any()
            ? throw new ArgumentException()
#pragma warning disable CA1827
            : _parameters.Count(x => !x.BoolValue) == 0;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
