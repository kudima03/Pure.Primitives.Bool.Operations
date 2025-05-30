﻿using Pure.Primitives.Abstractions.Bool;

namespace Pure.Primitives.Bool.Operations;

public sealed record Xor : IBool
{
    private readonly IEnumerable<IBool> _parameters;

    public Xor(params IBool[] parameters) : this(parameters.AsReadOnly()) { }

    public Xor(IEnumerable<IBool> parameters)
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

            return _parameters.Count(p => p.BoolValue) % 2 == 1;
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