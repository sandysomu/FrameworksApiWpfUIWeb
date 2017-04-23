using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Media.Animation;
using WHA_Framework.DBUtilities;
using WHA_Framework.DBUtilities.DTOs;

namespace WHA_Framework.Common.StepLibrary
{
    public class TableChanges
    {
        public static void updateTables(Transactions tsy)
        {
            using (var db = new FrameworkDBEntities())
            {
                //var tem= new tblTransaction()
                //{
                //    TranstionTypeId = Convert.ToInt64(from b in db.tblTransactionTypes where b.TransactionTypeName == tsy.TransType select b.TransactionTypeId),
                //    ACnameID = Convert.ToInt64(from b in db.tblAccountNames where b.ACname == tsy.AcName select b.ACnameID),
                //    Amount = Convert.ToInt64(tsy.Amount),
                //    BankId = Convert.ToInt64(from b in db.tblBanks where b.BankName == tsy.BankName select b.BankId),
                //    Date = tsy.Date

                //};

                var tem = new tblTransaction()
                {
                    TranstionTypeId = (from b in db.tblTransactionTypes where b.TransactionTypeName == tsy.TransType select b.TransactionTypeId).First(),
                    BankId = (from b in db.tblBanks where b.BankName == tsy.BankName select b.BankId).First(),
                    Amount = Convert.ToInt64(tsy.Amount),
                    Date = tsy.Date,
                    ACnameID = (from b in db.tblAccountNames where b.ACname == tsy.AcName select b.ACnameID).First(),
                   
                };


                db.tblTransactions.Add(tem);

                db.SaveChanges();

            }
        }
    }
}