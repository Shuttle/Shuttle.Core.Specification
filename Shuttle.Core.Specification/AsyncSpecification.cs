using System;
using System.Threading.Tasks;

namespace Shuttle.Core.Specification;

public class AsyncSpecification<T> : IAsyncSpecification<T>
{
    private readonly Func<T, Task<bool>> _function;

    public AsyncSpecification(Func<T, Task<bool>> function)
    {
        _function = function;
    }

    public async Task<bool> IsSatisfiedByAsync(T candidate)
    {
        return await _function.Invoke(candidate);
    }
}