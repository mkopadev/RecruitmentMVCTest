using System.Linq;
using System.Threading.Tasks;

namespace MKopa.RecruitmentTest.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(object id);
        T Get(object id);
        IQueryable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
