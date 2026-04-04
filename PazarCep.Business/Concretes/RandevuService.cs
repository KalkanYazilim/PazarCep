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
    public class RandevuService : BaseService<Randevu>,IRandevuService
    {
        public RandevuService(IBaseRepository<Randevu> repository) : base(repository)
        {
        }
    }
}
