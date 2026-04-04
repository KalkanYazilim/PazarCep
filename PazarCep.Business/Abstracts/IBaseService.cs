using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazarCep.Business.Abstracts
{
    public interface IBaseService<T> where T : class,IEntity,new()
    {
        List<T> GetAll();
        List<T> GetByFilter(Func<T, bool> filter);
        T Get(Func<T, bool> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
