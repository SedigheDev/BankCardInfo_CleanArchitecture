using ApplicationBankCardInfo.DataBase;
using ApplicationBankCardInfo.Dto;
using DomainBankCardInfo.Entities;

namespace ApplicationBankCardInfo.Services.AddNewBankCardInfo;

public class AddNewBankCardInfoService : IAddNewBankCardInfoService
{
    private readonly IDataBaseContext _dataBaseContext;

    public AddNewBankCardInfoService(IDataBaseContext dataBaseContext)
    {
        _dataBaseContext = dataBaseContext;
    }

    public ResultDto Execute(AddNewBankCardInfoDto newBankCardInfo)
    {
        if (string.IsNullOrEmpty(newBankCardInfo.BankCardNumber))
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = "شماره کارت بانکی اجباری می باشد.لطفا شماره کارت هم وارد کنید"
            };
        }

        BankCardInfo bankCardInfo = new BankCardInfo(newBankCardInfo.BankName, newBankCardInfo.BankCvv2,
            newBankCardInfo.BankAccountNumber
            , newBankCardInfo.BankCardNumber, newBankCardInfo.ExpireDate);
        _dataBaseContext.BankCardInfos.Add(bankCardInfo);
        _dataBaseContext.SaveChanges();
        return new ResultDto
        {
            IsSuccess = true,
            Message = $"کارت بانکی {newBankCardInfo.BankName} در دیتابیس با موفقیت ذخیره شد"
        };
    }
}