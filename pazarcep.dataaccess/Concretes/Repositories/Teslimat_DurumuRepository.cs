using pazarcep.dataaccess.Abstracts;
using pazarcep.dataaccess.Concretes.Ef.Conctexts;
using pazarcep.entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.dataaccess.Concretes.Repositories
{
    public class Teslimat_DurumuRepository : BaseRepository<Teslimat_Durumu, PazarCepContext>, ITeslimat_DurumuRepository
    {
    }
}
