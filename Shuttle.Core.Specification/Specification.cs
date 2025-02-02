using System;

namespace Shuttle.Core.Specification;

public class Specification<T> : ISpecification<T>
{
    private readonly Func<T, bool> _function;

    public Specification(Func<T, bool> function)
    {
        _function = function;
    }

    public bool IsSatisfiedBy(T candidate)
    {
        return _function(candidate);
    }
}