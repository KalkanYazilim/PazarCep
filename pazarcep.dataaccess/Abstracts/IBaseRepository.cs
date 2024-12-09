using pazarcep.entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.dataaccess.Abstracts
{
    public interface IBaseRepository<T> where T : class,IEntity, new()
    {
    }
}
