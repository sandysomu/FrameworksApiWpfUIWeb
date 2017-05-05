using System.Data.Entity;
using WHA.Framework.Database.DataModel;


namespace WHA_Framework.Common.StepLibrary
{
    public class TableChanges
    {
        public static void UpdateTblTransactions(tblTransaction tsy)
        {
            using (var db = new FrameworkDBEntities())
            {

                db.tblTransactions.Add(tsy);

                db.Entry(tsy).State = EntityState.Modified;

                db.SaveChanges();
                db.Dispose();

            }
        }

    }
}