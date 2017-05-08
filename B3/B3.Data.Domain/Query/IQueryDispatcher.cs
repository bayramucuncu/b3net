namespace B3.Data.Domain.Query
{
    public interface IQueryDispatcher
    {
        TResult Dispatch<TResult, TQuery>(TQuery query) where TQuery: IQuery<TResult>;
    }
}