using AutoMapper;
using WHA.Framework.Database;


namespace WHA_Framework.DataMappings
{
    public class DataMapper : IDataMapper
    {

        private readonly IMapper _mapper;

        public DataMapper()
        {
            Mapper.Initialize(config =>
            {
                //config.CreateMap<tblTransaction, Transaction>();
                //config.CreateMap<Transaction, tblTransaction>();
                });
            _mapper = Mapper.Instance;

        }
        
        public TOut Map<TIn, TOut>(TIn data) => _mapper.Map<TOut>(data);


        public void Map<TIn, TOut>(TIn source, TOut dest)
        {
            throw new System.NotImplementedException();
        }
    }
}