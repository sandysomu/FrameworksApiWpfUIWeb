using System;
using System.Linq;
using WHA_Framework.Database.SqliteDB;


namespace WHA_Framework.Utilities
{
    public class BankingService : IBankingService
    {
        public tblBank GetBankingInfo(string bankName)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblBanks.FirstOrDefault(b => b.BankName == bankName);
            }
        }

        public tblAccountName GetAcNameInfo(string acName)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblAccountNames.FirstOrDefault(b => b.ACname == acName);
            }
        }

        public tblTransactionType GetTransInfo(string TransTypeName)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblTransactionTypes.FirstOrDefault(b => b.TransactionTypeName == TransTypeName);
            }
        }

        public void DeleteBank()
        {
            throw new System.NotImplementedException();
        }
    }
}