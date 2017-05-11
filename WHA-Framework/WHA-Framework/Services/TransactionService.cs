using System.Linq;
using WHA.Framework.Database.Common;
using WHA.Framework.Database.DataMappings;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.Models;



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

        

        public Transaction GetTransaction(int id)
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
            return GetTransaction(id);
        }

        public void DeleteTransaction(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
