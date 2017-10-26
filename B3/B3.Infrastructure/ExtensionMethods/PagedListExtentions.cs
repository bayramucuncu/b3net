using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using B3.Infrastructure.PagedList;

namespace B3.Infrastructure.ExtensionMethods
{
    public static class PagedListExtentions
    {
        public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            return new PagedList<T>(source, pageNumber, pageSize);
        }

        public static IPagedList<T> ToPagedList<T>(this IQueryable<T> source, int pageNumber, int pageSize)
        {
            return new PagedList<T>(source, pageNumber, pageSize);
        }

        public static int PageNumber(this NameValueCollection formOrQueryString)
        {
            if (formOrQueryString == null) return 0;

            int pagenumber;
            int.TryParse(formOrQueryString["CurrentPage"], out pagenumber);

            return pagenumber;
        }
    }
}