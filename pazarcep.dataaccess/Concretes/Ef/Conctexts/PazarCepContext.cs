using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pazarcep.dataaccess.Concretes.Ef.Conctexts
{
    public class PazarCepContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"workstation id=PazerCep_DB.mssql.somee.com;packet size=4096;user id=KalkanYAZILIM_SQLLogin_1;pwd=e65ywzzxv9;data source=PazerCep_DB.mssql.somee.com;persist security info=False;initial catalog=PazerCep_DB;TrustServerCertificate=True");
        }
    }
}
