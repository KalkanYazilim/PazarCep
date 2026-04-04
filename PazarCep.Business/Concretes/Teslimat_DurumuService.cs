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
    public class Teslimat_DurumuService : BaseService<Teslimat_Durumu>, ITeslimat_DurumuService
    {
        public Teslimat_DurumuService(IBaseRepository<Teslimat_Durumu> repository) : base(repository)
        {
        }
    }
}
