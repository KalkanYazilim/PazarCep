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
    public class PuanGecmisiService : BaseService<PuanGecmisi>, IPuanGecmisiService
    {
        public PuanGecmisiService(IBaseRepository<PuanGecmisi> repository) : base(repository)
        {
        }
    }
}
