using WHA_Framework.Utilities;

namespace WHA_Framework.Conversion
{
    public class UpdateModel
    {
        private IBankingService _bankingService;

        public UpdateModel()
        {
            _bankingService = new BankingService();
        }
        //public EachEntityTran test(Transaction tran)
        //{
        //    var tes = new EachEntityTran()
        //    {
        //     Amount   = tran.Amount,
        //     AccountName = _bankingService.GetAcNameInfo(tran.ACnameID).ACname,
        //     TransactionType = _bankingService.GetTransTypeInfo(tran.TranstionTypeId).TransactionTypeName,
        //    };
        //    return tes;
        //}
        
    }
}