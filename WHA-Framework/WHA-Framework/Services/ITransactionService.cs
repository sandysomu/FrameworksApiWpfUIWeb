using WHA_Framework.Models;

namespace WHA_Framework.Services
{
    public interface ITransactionService
    {
        Transaction GetTransaction(int id);
        int PostTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
