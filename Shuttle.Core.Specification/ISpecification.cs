namespace Shuttle.Core.Specification;

public interface ISpecification<in T>
{
    bool IsSatisfiedBy(T candidate);
}