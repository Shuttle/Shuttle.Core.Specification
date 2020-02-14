using System;
using Shuttle.Core.Contract;

namespace Shuttle.Core.Specification
{
    public class Specification<T> : ISpecification<T>
    {
        private readonly Func<T, bool> _function;

        public Specification(Func<T, bool> function)
        {
            Guard.AgainstNull(function, nameof(function));

            _function = function;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return _function.Invoke(candidate);
        }
    }
}