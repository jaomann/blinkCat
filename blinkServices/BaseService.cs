using blinkCore.Contracts.Entities;
using blinkCore.Contracts.Repository;
using blinkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blinkServices
{
    internal class BaseService<T> : IBaseService<T> where T : EntityBase
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Create(T entity)
        {
            _baseRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _baseRepository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
           return _baseRepository.GetAll();
        }

        public T GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }
    }
}
