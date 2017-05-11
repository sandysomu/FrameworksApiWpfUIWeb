using WHA.Framework.Database.DataModel;

namespace WHA_Framework.Utilities
{
    public interface IBankingService
    {
        tblBank GetBankingInfo(int? bankId);
        tblAccountName GetAcNameInfo(int? acNameId);
        tblTransactionType GetTransTypeInfo(int? TransTypeId);
        
    }
}