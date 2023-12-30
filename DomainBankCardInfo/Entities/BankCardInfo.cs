using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainBankCardInfo.Entities
{
    public class BankCardInfo
    {
        public int Id { get; set; }
        public string BankName { get; private set; }
        public string BankCvv2 { get; private set; }
        public string BankAccountNumber { get; private set; }
        public string BankCardNumber { get;  private set; }
        public string ExpireDate { get; private set; }
        public DateTime CreateAt { get; private set; }


        public BankCardInfo() { }

        public BankCardInfo(string BankName,string BankCvv2,string BankAccountNumber,string BankCardNumber,string ExpireDate)
        {
            this.BankName = BankName;
            this.BankCvv2 = BankCvv2;   
            this.BankAccountNumber = BankAccountNumber;
            this.BankCardNumber = BankCardNumber;
            this.ExpireDate = ExpireDate;
            this.CreateAt= DateTime.Now;
        }

        public void UpDate(string BankName, string BankCvv2, string BankAccountNumber, string BankCardNumber,
            string ExpireDate)
        {
            this.BankName = BankName;
            this.BankCvv2 = BankCvv2;
            this.BankAccountNumber = BankAccountNumber;
            this.BankCardNumber = BankCardNumber;
            this.ExpireDate = ExpireDate;
        }
    }
}
