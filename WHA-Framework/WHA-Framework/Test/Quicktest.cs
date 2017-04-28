using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WHA_Framework.DBUtilities;
using System.Diagnostics;
using WHA_Framework.Common.StepLibrary;
using WHA_Framework.Database.SqliteDB;


//using WHA.DBUtilities;


namespace WHA.Test
{
    [TestFixture]
    class Quicktest
    {
        List<string> data = new List<string>();

        [Test]
        public void Test()
        {
            /* from b in context.Blogs 
                   where b.Name.StartsWith("B") 
                   select b; */
            using (var db = new FrameworkDBEntities())
            {

                //var cb = new tblAccountName() {ACnameID = 3, ACname = "Vihaan"};
                for (int i = 1; i < 10; i++)
                {

                    var ser = new tblTransaction()
                    {
                        ACnameID = 2,
                        Amount = 703,
                        BankId = 3,
                        Date = DateTime.Now,
                        TranstionTypeId = 2
                    };

                    db.tblTransactions.Add(ser);

                    db.Entry(ser).State = EntityState.Added;
                    db.SaveChanges();
                }
            }
        }

        [Test]
        public void Test1()
        {
            List<IndividualEntityReport> list = new List<IndividualEntityReport>();
            using (var db = new FrameworkDBEntities())
            {

                Console.WriteLine(db.tblAccountNames.FirstOrDefault().ACname.ToString());







                foreach (var tem in db.tblTransactions)
                {
                   
                    //list.Add(new IndividualEntityReport()
                    //{
                    //    AcName = (from p in db.tblAccountNames where p.ACnameID == tem.ACnameID select p.ACname).ToString(),
                    //    TransType = (from p in db.tblTransactionTypes where p.TransactionTypeId == tem.TranstionTypeId select p.TransactionTypeName).ToString(),
                    //    Amount = tem.Amount.Value,
                    //    TransID = tem.TransID
                    //});
                }
            }
            list.Add(new IndividualEntityReport() { AcName = "Something", TransID = 102340, Amount = 2032, CurrentBal = 23450, TransType = "De0bit" });
            list.Add(new IndividualEntityReport() { AcName = "Something1", TransID = 10234, Amount = 2032, CurrentBal = 23450, TransType = "De0bit" });
            list.Add(new IndividualEntityReport() { AcName = "Something2", TransID = 10234, Amount = 2032, CurrentBal = 23450, TransType = "Deb0it" });

        }

    }
}
