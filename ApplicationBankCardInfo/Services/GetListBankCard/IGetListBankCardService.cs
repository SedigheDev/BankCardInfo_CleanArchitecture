using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationBankCardInfo.DataBase;

namespace ApplicationBankCardInfo.Services.GetListBankCard
{
    public interface IGetListBankCardService
     {
         List<BankCardListDto> Execute(string SearchKey=null);
     }

    public class GetListBankCardService : IGetListBankCardService
    {
        private readonly IDataBaseContext _dataBaseContext;

        public GetListBankCardService(IDataBaseContext dataBaseContext)
        {
          _dataBaseContext=dataBaseContext;
        }
        public List<BankCardListDto> Execute(string SearchKey=null)
        {
            //SearchKey
            var ContactQuery = _dataBaseContext.BankCardInfos.AsQueryable();

            if (!string.IsNullOrEmpty(SearchKey))
            {
                ContactQuery = ContactQuery.Where(
                    p =>
                        p.BankName.Contains(SearchKey)
                        ||
                        p.BankCardNumber.Contains(SearchKey)
                        ||
                        p.BankAccountNumber.Contains(SearchKey)
                );

            }
            //GetListBankCardService
            var BankCardInfos = ContactQuery
                .Select(p => new BankCardListDto
            {
                BankName = p.BankName,
                BankCardNumber = p.BankCardNumber,
                ExpireDate =p.ExpireDate,
                Id = p.Id,
            }).ToList();
            return BankCardInfos;
        }
    }
}
