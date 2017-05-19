using WHA.Framework.Database.DTOs;

namespace WHA.Framework.Database.Common
{
    public interface IUpdateDbTables
    {
        bool UpdateTblEntity(EachEntityTran entityTran);
        bool UpdateTblTransaction(Transaction transaction);
    }
}