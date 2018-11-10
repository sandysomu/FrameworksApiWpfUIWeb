using System;

//namespace WHA_Framework.Models
namespace EntityDatabase.DTOs
{

    public class Transaction
    {
        public int TransID { get; set; } = 0;
        public int? BankId { get; set; }
        public int? ACnameID { get; set; }
        public int? TranstionTypeId { get; set; }
        public string TransDesc { get; set; }
        public double? Amount { get; set; }
        public DateTime Date { get; set; }
     
    }
}