using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record And : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public And(params IBool[] parameters) : this(parameters.AsReadOnly()) { }

    public And(IEnumerable<IBool> parameters)
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

            return _parameters.All(parameter => parameter.BoolValue);
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