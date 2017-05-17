using AutoMapper;
using WHA.Framework.Database.DataModel;
using WHA.Framework.Database.DTOs;


namespace WHA.Framework.Database.DataMappings
{
    public class DataMapper : IDataMapper
    {

        private readonly IMapper _mapper;

        public DataMapper()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<tblTransaction, Transaction>();
                config.CreateMap<Transaction, tblTransaction>();
                config.CreateMap<EachEntityTran, tblEachEntityTran>();

            });
            _mapper = Mapper.Instance;

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