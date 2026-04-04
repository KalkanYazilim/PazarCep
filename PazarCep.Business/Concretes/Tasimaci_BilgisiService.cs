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
    public class Tasimaci_BilgisiService : BaseService<Tasimaci_Bilgisi>, ITasimaci_BilgisiService
    {
        public Tasimaci_BilgisiService(IBaseRepository<Tasimaci_Bilgisi> repository) : base(repository)
        {
        }
    }
}
