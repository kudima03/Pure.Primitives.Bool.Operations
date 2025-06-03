using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record EqualCondition : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public EqualCondition(params IBool[] parameters) : this(parameters.AsReadOnly()) { }

    public EqualCondition(IEnumerable<IBool> parameters)
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

            return _parameters.DistinctBy(x => x.BoolValue).Count() == 1;
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