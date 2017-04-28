using AutoMapper;
using WHA_Framework.Database.SqliteDB;
using WHA_Framework.DBUtilities;
using WHA_Framework.Models;


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
                config.CreateMap<tblTransaction, Transaction>();
              
            });
        }
        
        public TOut Map<TIn, TOut>(TIn data)
        {
            return _mapper.Map<TOut>(data);
        }

        public void Map<TIn, TOut>(TIn source, TOut dest)
        {
            throw new System.NotImplementedException();
        }
    }
}