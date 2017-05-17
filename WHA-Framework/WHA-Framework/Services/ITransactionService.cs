using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;

namespace WHA_Framework.Services
{
    public interface ITransactionService
    {
   
        Transaction GetTransaction(int id);
        bool PostTransaction(Transaction transaction);
        void DeleteTransaction(int id);
        IEnumerable<Transaction> GetAllTransaction(int bankId);
    }

   
}
