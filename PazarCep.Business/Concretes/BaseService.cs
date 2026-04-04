using pazarcep.dataaccess.Abstracts;
using pazarcep.entity.Abstracts;
using PazarCep.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazarCep.Business.Concretes
{
    public class BaseService<T> : IBaseService<T> where T : class, IEntity, new()
    {

        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository) 
        { 
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public T Get(Func<T, bool> filter)
        {
            return _repository.Get(filter);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public List<T> GetByFilter(Func<T, bool> filter)
        {
            return _repository.GetByFilter(filter);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
