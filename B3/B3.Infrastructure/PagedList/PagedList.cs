using System;
using System.Collections.Generic;
using System.Linq;

namespace B3.Infrastructure.PagedList
{
    public class PagedList<T> : List<T>, IPagedList
    {
        public PagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
                throw new ArgumentOutOfRangeException("pageNumber", "pageNumber must be bigger then 1");

            if (pageSize < 1)
                throw new ArgumentOutOfRangeException("pageSize", "pageSize must be bigger then 1");
            
            TotalCount = source.Count();
            PageSize = pageSize;
            PageNumber = pageNumber;
            AddRange(source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList());
        }

        public PagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
                throw new ArgumentOutOfRangeException("pageNumber", "pageNumber must be bigger then 1");

            if (pageSize < 1)
                throw new ArgumentOutOfRangeException("pageSize", "pageSize must be bigger then 1");

            var enumerable = source as IList<T> ?? source.ToList();
            TotalCount = enumerable.Count;
            PageSize = pageSize;
            PageNumber = pageNumber;
            AddRange(enumerable.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList());
        }

        public int TotalCount { get; private set; }
        public int PageNumber { get; private set; }
        public int PageSize { get; private set; }
        public int NumberOfPages { get { return (int)Math.Ceiling(TotalCount / (double)PageSize); } }
        public bool HasPreviousPage { get { return PageNumber > 1; } }
        public bool HasNextPage { get { return PageNumber < NumberOfPages; } }
    }
}