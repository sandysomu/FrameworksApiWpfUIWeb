using WHA.Framework.Database.Models;


namespace WHA_Framework.Services
{
    public interface ITransactionService
    {
   
        Transaction GetTransaction(int id);
        bool PostTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }

   
}
