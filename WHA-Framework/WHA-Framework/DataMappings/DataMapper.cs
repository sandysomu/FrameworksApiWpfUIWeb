using AutoMapper;
using EntityDatabase.DataModel;
using EntityDatabase.DTOs;

namespace WpfApplication.DataMappings
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
                config.CreateMap<tblEachEntityTran, EachEntityTran >();

                //config.CreateMap<Transaction, EachEntityTran>()
                //   .ForMember(o => o.AccountName, m => m.MapFrom(s => s.))
                //   .ForMember(o => o.CompetitorID, m => m.MapFrom(s => s.CompetitorId))
                //   .ForMember(o => o.CompetitorName, m => m.MapFrom(s => s.Name))
                //   .ForAllOtherMembers(expression => expression.Ignore());

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