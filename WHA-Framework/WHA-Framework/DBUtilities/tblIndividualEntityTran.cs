//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WHA_Framework.DBUtilities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblIndividualEntityTran
    {
        public Nullable<int> TransId { get; set; }
        public string AccountName { get; set; }
        public string TransactionType { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> CurrentBalance { get; set; }
        public int IndividualID { get; set; }
    }
}
