using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;

namespace WHA.Framework.Database.Common
{
    public interface IUpdateDbTables
    {
        bool UpdateTblEntity(tblEachEntityTran entityTran);
        bool UpdateTblTransaction(tblTransaction transaction);
    }
}