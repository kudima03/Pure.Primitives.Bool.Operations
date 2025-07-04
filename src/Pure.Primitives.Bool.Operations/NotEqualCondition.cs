﻿using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record NotEqualCondition : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public NotEqualCondition(params IBool[] parameters) : this(parameters.AsReadOnly()) { }

    public NotEqualCondition(IEnumerable<IBool> parameters)
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

            return _parameters.DistinctBy(x => x.BoolValue).Count() > 1;
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