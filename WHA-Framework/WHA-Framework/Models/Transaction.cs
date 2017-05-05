using System;

namespace WHA_Framework.Models
{

    public class Transaction
    {
        public int TransID { get; set; } 
        public int? BankId { get; set; }
        public int? ACnameID { get; set; }
        public int? TranstionTypeId { get; set; }
        public string TransDesc { get; set; }
        public double? Amount { get; set; }
        public DateTime Date { get; set; }
      //  public int TransID { get; set; }
        
        //public Transaction GetBankName(string bankName)
        //{
        //    BankName = bankName; return this;
        //}
        //public Transaction getAcName(string acName) { AcName = acName; return this; }
        //public Transaction GetTransactionType(string transType) { TransType = transType; return this; }
        //public Transaction getTransDesc(string transDesc) { TransDesc = transDesc; return this; }
        //public Transaction getAmount(double amount) { Amount = amount; return this; }
        //public Transaction getDate(DateTime date) { Date = date; return this; }
    }
}