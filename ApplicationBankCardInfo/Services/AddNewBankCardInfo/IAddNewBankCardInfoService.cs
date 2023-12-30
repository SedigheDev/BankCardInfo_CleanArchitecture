using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBankCardInfo.Dto;

namespace ApplicationBankCardInfo.Services.AddNewBankCardInfo
{
    public interface IAddNewBankCardInfoService
    {
        ResultDto Execute(AddNewBankCardInfoDto addNewBankCardInfoDto);
    }
}
