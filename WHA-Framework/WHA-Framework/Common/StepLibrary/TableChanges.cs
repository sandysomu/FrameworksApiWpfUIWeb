using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Media.Animation;
using WHA_Framework.Database.SqliteDB;
using WHA_Framework.DBUtilities;

using WHA_Framework.Models;

namespace WHA_Framework.Common.StepLibrary
{
    public class TableChanges
    {
        public static void updateTblTransactions(tblTransaction tsy)
        {
            using (var db = new FrameworkDBEntities())
            {
                
                db.tblTransactions.Add(tsy);
                
                db.Entry(tsy).State=EntityState.Modified;

                db.SaveChanges();

            }
        }



    }
}