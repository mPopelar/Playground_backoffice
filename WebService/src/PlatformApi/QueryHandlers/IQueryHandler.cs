namespace PlatformApi.QueryHandlers
{
    public interface IQueryHandler<TResult, TQuery>
    {
        TResult Execute(TQuery query);
    }
}
