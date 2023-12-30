using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBankCardInfo.Services.AddNewBankCardInfo
{
    public class AddNewBankCardInfoDto
    {
        public string BankName { get; set; }
        public string BankCvv2 { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankCardNumber { get; set; }
        public string ExpireDate { get; set; }
    }
}
