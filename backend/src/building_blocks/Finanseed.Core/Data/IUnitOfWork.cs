using System.Threading.Tasks;

namespace Finanseed.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}