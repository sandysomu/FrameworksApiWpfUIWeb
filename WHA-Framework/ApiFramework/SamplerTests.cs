using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

namespace ApiFramework
{
    public class SamplerTests
    {

        [Fact]
        public void Test()
        {
          Task taskInstanace = Prints();
         //   Task<int> test = GetValue();
        }

        

        static async Task Prints()
        {
            Console.WriteLine("Printing initiated");
            await Task.CompletedTask;
        }
    }

}
