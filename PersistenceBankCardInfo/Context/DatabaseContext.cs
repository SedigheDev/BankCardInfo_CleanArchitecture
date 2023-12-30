using DomainBankCardInfo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBankCardInfo.DataBase;

namespace PersistenceBankCardInfo.Context
{
    public class DatabaseContext : DbContext,IDataBaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DbBankCardInfo;Integrated Security=True; TrustServerCertificate=True;");
        }
        public DbSet<BankCardInfo> BankCardInfos { get; set; }
    }
}
