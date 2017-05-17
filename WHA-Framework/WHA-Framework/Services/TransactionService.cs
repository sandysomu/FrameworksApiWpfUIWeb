using System.Collections.Generic;
using System.Linq;
using WHA.Framework.Database.Common;
using WHA.Framework.Database.DataMappings;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;


namespace WHA_Framework.Services
{
    public class TransactionService : ITransactionService
    {
        private IDataMapper _dataMapper;
        private UpdateDbTables _tblUpdate;

        public TransactionService()
        {
            _dataMapper = new DataMapper();
            _tblUpdate= new UpdateDbTables();
        }

        

        public Transaction GetSingleTransaction(int id)
        {
            using (var db = new FrameworkDBEntities())
            {
                var tblTransaction = db.tblTransactions.FirstOrDefault(p => p.TransID == id);
                return _dataMapper.Map<tblTransaction, Transaction>(tblTransaction);
            }
        }
        

        public  bool PostTransaction(Transaction transaction)
        {
            _tblUpdate.UpdateTblTransaction(transaction);

            return true;
        }


        Transaction ITransactionService.GetTransaction(int id)
        {
            return GetSingleTransaction(id);
        }

        public void DeleteTransaction(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Transaction> GetAllTransaction(int bankId)
        {
            var transactionList = new List<Transaction>();
            using (var db = new FrameworkDBEntities())
            {
                var tblTransactions = (from v in db.tblTransactions where v.BankId > bankId select v).ToList();
                return _dataMapper.Map<List<tblTransaction>, List<Transaction>>(tblTransactions);
            }
        }
    }
}
