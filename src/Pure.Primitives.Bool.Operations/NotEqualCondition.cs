using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record NotEqualCondition : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public NotEqualCondition(params IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    public bool BoolValue =>
        !_parameters.Any()
            ? throw new ArgumentException()
            : _parameters.DistinctBy(x => x.BoolValue).Count() > 1;

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}
