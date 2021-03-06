﻿using System.Linq;
using EntityDatabase.DataModel;

namespace WpfApplication.Services
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

        public tblTransactionType GetTransTypeInfo(string transTypeName)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblTransactionTypes.FirstOrDefault(b => b.TransactionTypeName == transTypeName);
            }
        }


        

        public void DeleteBank()
        {
            throw new System.NotImplementedException();
        }

        public tblBank GetBankingInfo(int bankNameId)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblBanks.FirstOrDefault(b => b.BankId == bankNameId);
            }
        }

        public tblAccountName GetAcNameInfo(int acNameId)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblAccountNames.FirstOrDefault(b => b.ACnameID == acNameId);
            }
        }

        public tblTransactionType GetTransTypeInfo(int transTypeNameId)
        {
            using (var db = new FrameworkDBEntities())
            {
                return db.tblTransactionTypes.FirstOrDefault(b => b.TransactionTypeId == transTypeNameId);
            }
        }

        public void GetMeMoreData()
        {
            throw new System.NotImplementedException();
        }
    }
}