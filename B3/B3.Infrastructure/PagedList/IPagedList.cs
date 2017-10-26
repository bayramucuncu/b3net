using System.Collections.Generic;

namespace B3.Infrastructure.PagedList
{
    public interface IPagedList<T>: IList<T>
    {
        int TotalCount { get; }
        int PageNumber { get; }
        int PageSize { get; }
        int NumberOfPages { get; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}