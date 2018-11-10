using System.Collections.Generic;
using EntityDatabase.DTOs;

namespace WpfApplication.Services
{
    public interface ITransactionService
    {
   
        Transaction GetTransaction(int id);
        bool PostTransaction(Transaction transaction);
        void DeleteTransaction(int id);
        IEnumerable<EachEntityTran> GetTransactionforEachEntity(string bankName);
        IEnumerable<EachEntityTran> GetAllTransaction();
    }

   
}
