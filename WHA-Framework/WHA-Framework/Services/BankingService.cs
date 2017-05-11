using System.Linq;
using WHA.Framework.Database.DataModel;


namespace WHA_Framework.Utilities
{
    public class BankingService : IBankingService
    {
        public tblBank GetBankingInfo(int bankId)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblBanks.FirstOrDefault(b => b.BankId == bankId);
            }
        }

        public tblAccountName GetAcNameInfo(int? acNameId)
        {
            throw new System.NotImplementedException();
        }

        public tblAccountName GetAcNameInfo(int? acId)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblAccountNames.FirstOrDefault(b => b.ACnameID == acId);
            }
        }

        public tblTransactionType GetTransTypeInfo(int? TransTypeId)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblTransactionTypes.FirstOrDefault(b => b.TransactionTypeId == TransTypeId);
            }
        }

        public void DeleteBank()
        {
            throw new System.NotImplementedException();
        }





    }
}