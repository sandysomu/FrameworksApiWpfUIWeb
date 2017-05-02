using System.Linq;
using WHA.Framework.Database;
using WHA.Framework.Database.DataModel.SqliteDB;
using WHA_Framework.DataMappings;
using WHA_Framework.Models;


namespace WHA_Framework.Services
{
    public class TransactionService : ITransactionService
    {
        private IDataMapper _dataMapper;

        public TransactionService()
        {
            _dataMapper = new DataMapper();
        }

        public Transaction GetTransaction(int id)
        {
            
            using (var db = new FrameworkDBEntities())
            {
                var tblTransaction = db.tblTransactions.FirstOrDefault(p => p.TransID == id);
                return _dataMapper.Map<tblTransaction, Transaction>(tblTransaction);
            }

            //var transaction = Mapper.Map<Transaction>(tblTrans);

            //Transaction transaction = _dataMapper.Map<tblTransaction, Transaction>(tblTrans);
            
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
