using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WHA_Framework.DBUtilities;

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
            using (var db = new FrameworkDBEntities())
            {
                var tempRecord = new Temporary() {FirstName = "First Name", LastName = "Second Name"};
                db.Temporaries.Add(tempRecord);
                db.Entry(tempRecord).State = EntityState.Added;

                db.SaveChanges();
            }

        }
        
    }
}
