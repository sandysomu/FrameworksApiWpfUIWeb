//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDatabase.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEachEntityTran
    {
        public long TransID { get; set; }
        public string TransactionType { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string TransDesc { get; set; }
        public Nullable<long> Amount { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<long> CurrentBalance { get; set; }
    }
}
