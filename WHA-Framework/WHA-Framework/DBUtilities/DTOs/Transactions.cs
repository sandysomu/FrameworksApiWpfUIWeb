using System;
using System.IO.Packaging;

namespace WHA_Framework.DBUtilities.DTOs
{
    public class Transactions
    {
        public string BankName { get; set; }
        public string AcName { get; set; }
        public string TransType { get; set; }
        public string TransDesc { get; set; }
        public double? Amount { get; set; }
        public DateTime Date { get; set; }

        public Transactions GetBankName(string bankName) { BankName = bankName; return this; }
        public Transactions getAcName(string acName) { AcName = acName; return this; }
        public Transactions GetTransactionType(string transType) { TransType = transType; return this; }
        public Transactions getTransDesc(string transDesc) { TransDesc = transDesc; return this; }
        public Transactions getAmount(double amount) { Amount = amount; return this; }
        public Transactions getDate(DateTime date) { Date = date; return this; }


    }
}
