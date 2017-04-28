using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using WHA_Framework.Database.SqliteDB;
using WHA_Framework.DataMappings;
using WHA_Framework.Models;

namespace WHA_Framework.Services
{
    public class TransactionService : ITransactionService
    {
        private IDataMapper _dataMapper = new DataMapper();
        public Transaction GetTransaction(int id)
        {
            tblTransaction tblTrans;
            using (var db = new FrameworkDBEntities())
            {
                tblTrans = db.tblTransactions.FirstOrDefault(p => p.TransID == id);
            }

            Transaction transaction = _dataMapper.Map<tblTransaction, Transaction>(tblTrans);
            return transaction;
        }

        public int PostTransaction(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteTransaction(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
