using pazarcep.dataaccess.Abstracts;
using pazarcep.entity.Concretes;
using PazarCep.Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazarCep.Business.Concretes
{
    public class YukService : BaseService<Yuk>, IYukService
    {
        public YukService(IBaseRepository<Yuk> repository) : base(repository)
        {
        }
    }
}
