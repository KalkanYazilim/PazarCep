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
    public class YukVeren_BilgisiRepository : BaseRepository<YukVeren_Bilgisi, PazarCepContext>, IYukVeren_BilgisiRepository
    {
    }
}
