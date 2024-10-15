using System.Threading.Tasks;

namespace Shuttle.Core.Specification;

public interface IAsyncSpecification<in T>
{
    Task<bool> IsSatisfiedByAsync(T candidate);
}