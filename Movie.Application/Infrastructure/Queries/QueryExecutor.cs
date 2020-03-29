namespace Movie.Application.Infrastructure.Queries
{
    public class QueryExecutor
    {
        public QueryExecutionResult<TResult> Execute<TQuery, TResult>(TQuery query) where TQuery : Query<TResult> where TResult : class
        {
            return query.Execute();
        }
    }
}
