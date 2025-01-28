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
    public class YukVeren_BilgisiService : BaseService<YukVeren_Bilgisi>, IYukVeren_BilgisiService
    {
        public YukVeren_BilgisiService(IBaseRepository<YukVeren_Bilgisi> repository) : base(repository)
        {
        }
    }
}
