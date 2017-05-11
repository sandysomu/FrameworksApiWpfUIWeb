using System;
using NUnit.Framework;
using WHA.Framework.Database.Common;
using WHA.Framework.Database.DataMappings;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.Models;

namespace WHA.Test
{
    [TestFixture]
    class Quicktest
    {
        private readonly IDataMapper _dataMapper = new DataMapper();
        readonly UpdateDbTables _tblUpdate;

        public Quicktest()
        {
            _tblUpdate = new UpdateDbTables();
        }

        [Test]
        public void Test()
        {
            var cb = new tblAccountName() { ACnameID = 3, ACname = "Vihaan" };
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
    }
}
