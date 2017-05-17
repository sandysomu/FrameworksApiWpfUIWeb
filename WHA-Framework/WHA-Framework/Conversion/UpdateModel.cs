﻿using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;
using WHA_Framework.Utilities;
using System.Linq;

namespace WHA_Framework.Conversion
{
    public class UpdateModel
    {
        private IBankingService _bankingService;


        public UpdateModel()
        {
            _bankingService = new BankingService();
        }


        public EachEntityTran test(Transaction tran)
        {
            var tes = new EachEntityTran()
            {
                AccountName = _bankingService.GetAcNameInfo((int)tran.ACnameID).ACname,
                TransactionType = _bankingService.GetTransTypeInfo((int)tran.TranstionTypeId).TransactionTypeName,
                BankName = _bankingService.GetBankingInfo((int)tran.BankId).BankName,
                TransDesc = tran.TransDesc,
                Amount = tran.Amount,
                CurrentBalance = 0,
                Date = tran.Date,
                TransID = tran.TransID
                //TransactionType = _bankingService.GetTransTypeInfo(tran.TranstionTypeId).TransactionTypeName,
            };
            return tes;
        }








    }
}