using System;
using System.CodeDom.Compiler;
using System.Data.Entity;
using System.Linq;
using WHA.Framework.Database.DataMappings;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;



namespace WHA.Framework.Database.Common
{
    public class UpdateDbTables
    {
        private readonly IDataMapper _dataMapper;


        public UpdateDbTables()
        {
            _dataMapper = new DataMapper();

        }

        public bool UpdateTblTransaction(Transaction transaction)
        {
            try
            {
                using (var db = new FrameworkDBEntities())
                {

                    var tblTransaction1 = _dataMapper.Map<Transaction, tblTransaction>(transaction);
                    db.tblTransactions.Add(tblTransaction1);
                    db.Entry(tblTransaction1).State = EntityState.Added;
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

        
        public bool UpdateTblEntity(EachEntityTran entityTran)
        {

            using (var db = new FrameworkDBEntities())
            {

                var entityTran1 = _dataMapper.Map<EachEntityTran, tblEachEntityTran>(entityTran);
                db.tblEachEntityTrans.Add(entityTran1);
                db.Entry(entityTran1).State = EntityState.Added;
                db.SaveChanges();
                db.Dispose();
                return true;
            }
        }

    }

}
