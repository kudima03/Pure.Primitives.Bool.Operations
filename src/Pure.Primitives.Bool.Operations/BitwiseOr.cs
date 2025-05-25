using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record BitwiseOr : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public BitwiseOr(params IBool[] parameters) : this(parameters.AsReadOnly()) { }

    public BitwiseOr(IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    bool IBool.Value
    {
        get
        {
            if (!_parameters.Any())
            {
                throw new ArgumentException();
            }

            return _parameters.Count(parameter => parameter.Value) > 0;
        }
    }

    public override int GetHashCode()
    {
        throw new NotSupportedException();
    }

    public override string ToString()
    {
        throw new NotSupportedException();
    }
}