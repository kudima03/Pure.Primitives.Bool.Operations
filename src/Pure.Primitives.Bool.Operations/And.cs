using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record And : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public And(params IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    public bool BoolValue =>
        !_parameters.Any()
            ? throw new ArgumentException()
            : _parameters.All(parameter => parameter.BoolValue);

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
