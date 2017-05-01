using NUnit.Framework;
using WHA_Framework.Services;

namespace WHA.Framework.WebApi.Test
{
    [TestFixture]
    public class Testing
    {
        private ITransactionService tran;

        [Test]
        public void test1Sandy()
        {
            tran = new TransactionService();
            tran.GetTransaction(3);
        }
    }
}