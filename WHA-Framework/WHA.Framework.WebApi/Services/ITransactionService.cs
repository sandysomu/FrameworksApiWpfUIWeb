using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHA.Framework.WebApi.Models;

namespace WHA_Framework.Services
{
    public interface ITransactionService
    {
        Transaction GetTransaction(int id);
        int PostTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
