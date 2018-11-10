using EntityDatabase.DTOs;
using WpfApplication.Services;

namespace WpfApplication.Conversion
{
    public class ObjectConversions 
    {
        private readonly IBankingService _bankingService;


        public ObjectConversions()
        {
            _bankingService = new BankingService();
        }


        public EachEntityTran ConvertTransactionToEachEntityTran(Transaction tran)
        {
            var tes = new EachEntityTran()
            {
                AccountName = _bankingService.GetAcNameInfo((int)tran.ACnameID).ACname,
                TransactionType = _bankingService.GetTransTypeInfo((int)tran.TranstionTypeId).TransactionTypeName,
                BankName = _bankingService.GetBankingInfo((int)tran.BankId).BankName,
                TransDesc = tran.TransDesc,
                Amount = (long)tran.Amount,
                CurrentBalance = 0,
                Date = tran.Date,
                TransID = tran.TransID
            };
            return tes;
        }

    }
}