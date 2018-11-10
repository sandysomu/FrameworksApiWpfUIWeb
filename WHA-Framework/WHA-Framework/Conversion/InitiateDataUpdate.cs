using Autofac;
using EntityDatabase.Common;
using EntityDatabase.DataModel;
using EntityDatabase.DTOs;
using WpfApplication.DataMappings;
using WpfApplication.IoC;

namespace WpfApplication.Conversion
{

    public class InitiateDataUpdate
    {

        private readonly IDataMapper _dataMapper;
        private readonly IUpdateDbTables _tblUpdate;

        public InitiateDataUpdate()
        {
            _dataMapper = IocConfiguration.Initialize().Resolve<IDataMapper>();
            _tblUpdate = IocConfiguration.Initialize().Resolve<IUpdateDbTables>();
        }

        public void UpdateTblTransaction(Transaction transaction)
        {
            _tblUpdate.UpdateTblTransaction(_dataMapper.Map<Transaction, tblTransaction>(transaction));
        }

        public void UpdateTblEntity(EachEntityTran convertTransactionToEachEntityTran)
        {
            _tblUpdate.UpdateTblEntity(_dataMapper.Map< EachEntityTran, tblEachEntityTran>(convertTransactionToEachEntityTran));
        }
    }
}