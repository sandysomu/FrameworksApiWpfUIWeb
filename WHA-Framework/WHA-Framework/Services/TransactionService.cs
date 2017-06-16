using System.Collections.Generic;
using System.Linq;
using WHA.Framework.Database.Common;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;
using WHA_Framework.Conversion;
using WHA_Framework.DataMappings;


namespace WHA_Framework.Services
{
    public class TransactionService : ITransactionService
    {
        private IDataMapper _dataMapper;
        private InitiateDataUpdate _dataUpdate;

        public TransactionService()
        {
            _dataMapper = new DataMapper();
            _dataUpdate= new InitiateDataUpdate();
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
            _dataUpdate.UpdateTblTransaction(transaction);
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

        public IEnumerable<EachEntityTran> GetTransactionforEachEntity(string bankName)
        {
            GetAllTransaction();
            var transactionList = new List<EachEntityTran>();
            using (var db = new FrameworkDBEntities())
            {
                var tblTransactions = (from v in db.tblEachEntityTrans where v.BankName.Trim() == bankName select v).ToList();
                return _dataMapper.Map<List<tblEachEntityTran>, List<EachEntityTran>>(tblTransactions);
            }
        }

        public IEnumerable<EachEntityTran> GetAllTransaction()
        {
            var transactionList = new List<EachEntityTran>();
            using (var db = new FrameworkDBEntities())
            {
                var tblTransactions = (from v in db.tblEachEntityTrans select v).ToList();
                return _dataMapper.Map<List<tblEachEntityTran>, List<EachEntityTran>>(tblTransactions);
            }
        }


    }
}
