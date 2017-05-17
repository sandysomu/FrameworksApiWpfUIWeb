﻿using System;

namespace  WHA.Framework.Database.DTOs

{
    public class EachEntityTran
    {
     
        public string AccountName { get; set; }
        public string TransactionType { get; set; }

        public int TransID { get; set; } 
        public string TransDesc { get; set; }
        public string BankName { get; set; }
        public double? Amount { get; set; }
        public DateTime Date { get; set; }
        public long? CurrentBalance { get; set; }
    }


}