using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WHA.Framework.WebApi.Models;
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

    }
}
