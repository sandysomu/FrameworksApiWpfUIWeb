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
            //   UpdateTblEachEnity(ConvertToEachEntityTran(transaction));
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



        public bool UpdateTblEntity(EachEntityTran transaction)
        {
            //   UpdateTblEachEnity(ConvertToEachEntityTran(transaction));
            try
            {
                using (var db = new FrameworkDBEntities())
                {

                    var tblTransaction1 = _dataMapper.Map<EachEntityTran, tblEachEntityTran>(transaction);
                    db.tblEachEntityTrans.Add(tblTransaction1);
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









    }



    

}
