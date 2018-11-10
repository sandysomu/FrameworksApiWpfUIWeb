using System.Web.Http;
using EntityDatabase.DTOs;
using WpfApplication.Services;

namespace WpfAPI.Controllers
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
          _transactionService.PostTransaction(model);
            return Ok();
        }


    }
}
