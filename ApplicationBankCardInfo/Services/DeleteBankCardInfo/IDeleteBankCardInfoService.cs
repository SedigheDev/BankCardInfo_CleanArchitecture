using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBankCardInfo.DataBase;
using ApplicationBankCardInfo.Dto;

namespace ApplicationBankCardInfo.Services.DeleteBankCardInfo
{
    public  interface IDeleteBankCardInfoService
    {
        ResultDto Execute(int BankId);
    }

    public class DeleteBankCardInfoService : IDeleteBankCardInfoService
    {
        private readonly IDataBaseContext _dataBaseContext;
        public DeleteBankCardInfoService(IDataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public ResultDto Execute(int BankId)
        {
            var BankCardInfo = _dataBaseContext.BankCardInfos.Find(BankId);
            if (BankCardInfo != null)
            {
                _dataBaseContext.BankCardInfos.Remove(BankCardInfo);
                _dataBaseContext.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "کارت بانکی با موفقیت حذف شد."
                };
            }
            return new ResultDto
            {
                IsSuccess = false,
                Message = "کارت بانکی یافت نشد"
            };
        }
    }
}
