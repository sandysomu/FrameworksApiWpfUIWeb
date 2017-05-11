using System.Web.Http;
using WHA.Framework.Database.Models;
using WHA_Framework.Services;

namespace WHA.Framework.WebApi.Controllers
{
    public class TransactionController : ApiController
    {

        private ITransactionService _transactionService;

        public TransactionController()
        {
            _transactionService = new TransactionService();
        }

        [Route("Transactions/GetTransactionById/{id}")]
        public Transaction GetTransaction(int id)
        {
            return _transactionService.GetTransaction(id);
        }

        [Route("Transactions/PostTransactionById")]
        public IHttpActionResult PostTransaction(Transaction model)
        {
            var tem = model;
            _transactionService.PostTransaction(model);
            return Ok();
        }


    }
}
