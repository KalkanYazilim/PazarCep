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
    public class Ciftci_BilgisiService : BaseService<Ciftci_Bilgisi>, ICiftci_BilgisiService
    {
        public Ciftci_BilgisiService(IBaseRepository<Ciftci_Bilgisi> repository) : base(repository)
        {
        }
    }
}
