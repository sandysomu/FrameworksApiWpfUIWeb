namespace WHA_Framework.DataMappings
{
    public interface IDataMapper
    {
        TOut Map<TIn, TOut>(TIn data);
        void Map<TIn, TOut>(TIn source, TOut dest);

    }
}