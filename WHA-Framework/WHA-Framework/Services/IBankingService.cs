using EntityDatabase.DataModel;

namespace WpfApplication.Services
{
    public interface IBankingService
    {
        tblBank GetBankingInfo(string bankName);
        tblAccountName GetAcNameInfo(string acName);
        tblTransactionType GetTransTypeInfo(string transTypeName);

        tblBank GetBankingInfo(int bankNameId);
        tblAccountName GetAcNameInfo(int acNameId);
        tblTransactionType GetTransTypeInfo(int transTypeNameId);

        void GetMeMoreData();


    }
}