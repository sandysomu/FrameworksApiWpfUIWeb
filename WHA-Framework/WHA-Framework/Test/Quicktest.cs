using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WHA_Framework.DBUtilities;
using System.Diagnostics;
//using WHA.DBUtilities;


namespace WHA.Test
{
    [TestFixture]
    class Quicktest
    {
        List<string> data = new List<string>();

        [Test]
        public void Test()
        {
            /* from b in context.Blogs 
                   where b.Name.StartsWith("B") 
                   select b; */
            using (var db = new FrameworkDBEntities())
            {
                var some = (from b in db.tblBanks where b.BankId > 0 select b.BankName).ToList();


                var cb = new tblAccountName() {ACnameID = 3, ACname = "Vihaan"};

                var ser= new tblTransaction() {};
                

                db.tblAccountNames.Add(cb);
                db.SaveChanges();
             }


    }

}
}
