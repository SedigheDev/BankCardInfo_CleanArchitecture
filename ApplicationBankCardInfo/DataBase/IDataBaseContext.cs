using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainBankCardInfo.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationBankCardInfo.DataBase
{
    public interface IDataBaseContext
    {
        public DbSet<BankCardInfo>BankCardInfos { get; set; }
        public int SaveChanges();
    }
}
