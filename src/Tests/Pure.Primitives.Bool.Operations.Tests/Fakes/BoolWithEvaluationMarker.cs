using Pure.Primitives.Abstractions.Bool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure.Primitives.Bool.Operations.Tests.Fakes;
public sealed record BoolWithEvaluationMarker : IBool
{
    private readonly bool _value;

    public BoolWithEvaluationMarker(bool value)
    {
        _value = value;
    }

    public bool BoolValue
    {
        get
        {
            Evaluated = true;
            return _value;
        }
    }

    public bool Evaluated { get; private set; }
}