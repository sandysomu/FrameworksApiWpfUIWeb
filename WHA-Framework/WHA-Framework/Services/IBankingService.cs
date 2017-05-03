using WHA.Framework.Database.DataModel;

namespace WHA_Framework.Utilities
{
    public interface IBankingService
    {
        tblBank GetBankingInfo(string bankName);
        tblAccountName GetAcNameInfo(string acName);
        tblTransactionType GetTransInfo(string TransTypeName);

       
    }
}