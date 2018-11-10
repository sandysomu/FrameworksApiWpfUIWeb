using System;
using EntityDatabase.DTOs;
using NUnit.Framework;
using WpfApplication.Conversion;
using WpfApplication.DataMappings;

namespace WpfApplication.Test
{
    [TestFixture]
    class Quicktest
    {
        private readonly IDataMapper _dataMapper = new DataMapper();
        readonly InitiateDataUpdate _tblUpdate;


        public Quicktest()
        {
            _tblUpdate = new InitiateDataUpdate();
        }

        [Test]
        public void Test()
        {
            //   var cb = new tblAccountName() { ACnameID = 3, ACname = "Vihaan" };
            for (int i = 1; i <= 1; i++)
            {

                var transaction = new Transaction()
                {
                    ACnameID = 2,
                    Amount = 703,
                    BankId = 3,
                    Date = DateTime.Now,
                    TranstionTypeId = 2,
                    TransDesc = "forth 89 attempt to write data"
                };
                _tblUpdate.UpdateTblTransaction(transaction);
            }
        }


        [Test]
        public void Test1()
        {
            // Open the window
           
           
        }


    }
}
