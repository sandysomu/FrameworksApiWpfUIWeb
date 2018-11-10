using NUnit.Framework;
using WpfApplication.Services;

namespace WpfAPI.Test
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