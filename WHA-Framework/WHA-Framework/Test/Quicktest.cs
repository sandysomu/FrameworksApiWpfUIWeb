using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using NUnit.Framework;
using WHA.Framework.Database.DataModel;
using WHA_Framework.Common.StepLibrary;
using WHA_Framework.DataMappings;
using WHA_Framework.Models;
using WHA_Framework.Services;



//using WHA.DBUtilities;


namespace WHA.Test
{
    [TestFixture]
    class Quicktest
    {
        private readonly IDataMapper _dataMapper = new DataMapper();

        [Test]
        public void Test()
        {
            using (var db = new FrameworkDBEntities())
            {

                //var cb = new tblAccountName() {ACnameID = 3, ACname = "Vihaan"};
                for (int i = 1; i <= 1; i++)
                {

                    var ser = new Transaction()
                    {
                        ACnameID = 2,
                        Amount = 703,
                        BankId = 3,
                        Date = DateTime.Now,
                        TranstionTypeId = 2,
                        TransDesc = "forth 89 attempt to write data"
                    };

                    var tblTransaction1 = _dataMapper.Map<Transaction, tblTransaction>(ser);
                    db.Dispose();
                    TableChanges.UpdateTblTransactions(tblTransaction1);

                    db.tblTransactions.Add(tblTransaction1);
                    db.Entry(tblTransaction1).State = EntityState.Added;
                    db.SaveChanges();
                }
               // db.SaveChanges();
               


            }
        }

        [Test]
        public void Test1()
        {
            using (var db = new FrameworkDBEntities())
            {

                var transaction = new Transaction
                {
                    ACnameID = 2,
                    Amount = 703,
                    BankId = 3,
                    Date = DateTime.Now,
                    TranstionTypeId = 2,
                    TransDesc = "forth 59 attempt to write data"

                };

                var tblTransaction1 = _dataMapper.Map<Transaction, tblTransaction>(transaction);

              //  TableChanges.UpdateTblTransactions(tblTransaction1);



                db.tblTransactions.Add(tblTransaction1);
                db.Entry(tblTransaction1).State = EntityState.Added;
                db.SaveChanges();
            }
        }

       
    }
}
