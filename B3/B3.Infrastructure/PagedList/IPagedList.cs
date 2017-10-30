using System.Collections;

namespace B3.Infrastructure.PagedList
{
    public interface IPagedList : IList
    {
        int TotalCount { get; }
        int PageNumber { get; }
        int PageSize { get; }
        int NumberOfPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}