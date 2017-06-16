using System;
using System.CodeDom.Compiler;
using System.Data.Entity;
using System.Linq;

using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;



namespace WHA.Framework.Database.Common
{
    public class UpdateDbTables : IUpdateDbTables
    {
       
        public bool UpdateTblTransaction(tblTransaction transaction)
        {
            try
            {
                using (var db = new FrameworkDBEntities())
                {
                    db.tblTransactions.Add(transaction);
                    db.Entry(transaction).State = EntityState.Added;
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public bool UpdateTblEntity(tblEachEntityTran entityTran)
        {
            try
            {
                using (var db = new FrameworkDBEntities())
                {
                    db.tblEachEntityTrans.Add(entityTran);
                    db.Entry(entityTran).State = EntityState.Added;
                    db.SaveChanges();
                    db.Dispose();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }

}
