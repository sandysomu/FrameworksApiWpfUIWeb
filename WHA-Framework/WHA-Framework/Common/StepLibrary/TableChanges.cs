using WHA.Framework.Database.DataModel.SqliteDB;


namespace WHA_Framework.Common.StepLibrary
{
    public class TableChanges
    {
        public static void updateTblTransactions(tblTransaction tsy)
        {
            using (var db = new FrameworkDBEntities())
            {
                
             //   db.tblTransactions.Add(tsy);
                
            //    db.Entry(tsy).State=EntityState.Modified;

           //     db.SaveChanges();

            }
        }



    }
}