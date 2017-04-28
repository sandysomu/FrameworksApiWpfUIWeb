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
using WHA_Framework.Services;


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
            TransactionService some = new TransactionService();
            var temp = some.GetTransaction(0);
        }

       
    }
}
