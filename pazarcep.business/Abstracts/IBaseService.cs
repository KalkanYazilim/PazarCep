using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.business.Abstracts
{
    public interface IBaseService<T> where T : class,IEntity,new()
    {
    }
}
