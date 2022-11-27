using System;
using Shuttle.Core.Contract;

namespace Shuttle.Core.Specification
{
    public class Specification<T> : ISpecification<T>
    {
        private readonly Func<T, bool> _function;

        public Specification(Func<T, bool> function)
        {
            _function = Guard.AgainstNull(function, nameof(function));
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return _function.Invoke(candidate);
        }
    }
}