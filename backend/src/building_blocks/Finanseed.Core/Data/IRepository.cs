using Finanseed.Core.Entities;

namespace Finanseed.Core.Data
{
    public interface IRepository<T> where T : IAggregationRoot
    {
        void Register(T entity);
        T Get();
    }
}