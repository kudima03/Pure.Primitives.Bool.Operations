using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record BitwiseAnd : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public BitwiseAnd(params IBool[] parameters) : this(parameters.AsReadOnly()) { }

    public BitwiseAnd(IEnumerable<IBool> parameters)
    {
        _parameters = parameters;
    }

    bool IBool.BoolValue
    {
        get
        {
            if (!_parameters.Any())
            {
                throw new ArgumentException();
            }

            return _parameters.Count(x => x.BoolValue is false) == 0;
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