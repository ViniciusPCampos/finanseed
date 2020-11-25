using Finanseed.Core.Entities;

namespace Finanseed.Core.Data
{
    public class RepositoryBase<T> : IRepository<T>
        where T : IAggregationRoot
    {
        public void Register(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get()
        {
            throw new System.NotImplementedException();
        }
    }
}