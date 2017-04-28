using AutoMapper;
using WHA_Framework.DBUtilities;

using WHA_Framework.DBUtilities.SqliteDB;


namespace WHA_Framework.DataMappings
{
    public class DataMapper : IDataMapper
    {

        private readonly IMapper _mapper;

        public DataMapper()
        {
            Mapper.Initialize(config =>
            {
                //config.CreateMap<tblBank, Bank>();
                //config.CreateMap<tblTransaction, Transactions>();
                //config.CreateMap<Transactions, tblTransaction>();
            });
        }
        
        public TOut Map<TIn, TOut>(TIn data)
        {
            throw new System.NotImplementedException();
        }

        public void Map<TIn, TOut>(TIn source, TOut dest)
        {
            throw new System.NotImplementedException();
        }
    }
}