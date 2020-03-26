using R.ARC.Common.Helper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace R.ARC.Common.Helper.Paging
{
    public class PagedList<T>
    {
        public PagedList(IQueryable<T> queryable, PagedListParameters parameters, Type entityType = null)
        {
            entityType = entityType ?? typeof(T);

            if (queryable == null || parameters == null)
            {
                return;
            }

            if (parameters.Filter != null && parameters.Filter.Value != null && parameters.Filter.Key != null)
            {
                string filterKey = parameters.Filter.Key;
                string filterVal = parameters.Filter.Value;

                var propInfo = entityType.GetProperty(filterKey);

                if (propInfo != null)
                    queryable = queryable.Where(m => (m.GetType().GetProperty(filterKey).GetValue(m) as string).Contains(filterVal));
            }

            Count = queryable.LongCount();

            //parameters.Orders?.ToList().ForEach(order => queryable = queryable.OrderBy(order.Property, order.IsAscending));

            if (parameters.Page != null && parameters.Page.Index > -1 && parameters.Page.Size > 0)
            {
                queryable = queryable.Page(parameters.Page.Index, parameters.Page.Size);
            }

            List = queryable.AsEnumerable();
        }

        public long Count { get; }

        public IEnumerable<T> List { get; set; }
    }
}
