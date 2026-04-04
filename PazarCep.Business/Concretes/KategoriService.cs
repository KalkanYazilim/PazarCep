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
    public class KategoriService : BaseService<Kategori>, IKategoriService
    {
        public KategoriService(IBaseRepository<Kategori> repository) : base(repository)
        {
        }
    }
}
