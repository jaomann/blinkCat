using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blinkCore.Contracts.Repository
{
    public interface IBaseRepository<T>
    {
        Task Add(T entity);
        Task Delete(Guid id);
        Task Update(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
