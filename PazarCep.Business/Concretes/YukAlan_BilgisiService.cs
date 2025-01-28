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
    public class YukAlan_BilgisiService : BaseService<YukAlan_Bilgisi>, IYukAlan_BilgisiService
    {
        public YukAlan_BilgisiService(IBaseRepository<YukAlan_Bilgisi> repository) : base(repository)
        {
        }
    }
}
