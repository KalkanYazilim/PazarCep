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
    public class TakipciService : BaseService<Takipci>, ITakipciService
    {
        public TakipciService(IBaseRepository<Takipci> repository) : base(repository)
        {
        }
    }
}
