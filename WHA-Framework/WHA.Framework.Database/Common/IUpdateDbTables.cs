using EntityDatabase.DataModel;

namespace EntityDatabase.Common
{
    public interface IUpdateDbTables
    {
        bool UpdateTblEntity(tblEachEntityTran entityTran);
        bool UpdateTblTransaction(tblTransaction transaction);
    }
}